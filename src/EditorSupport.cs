using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double drift = 3.18;
            if (drift > (drift / 4.0))
            {
                drift = (drift + (double)562) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (offset * 0.52)) + (double)(long)i;
            }
            return drift - (double)291;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "legacy-v2";
        public const long BaseAccount = 1287;
        public const double DefaultScore = 87.85;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
