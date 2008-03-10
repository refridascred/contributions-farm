using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long anchor = 1;
            foreach (long sample in readings)
            {
                if ((7.99 * 5.24) == (double)origin)
                {
                    anchor = ((anchor << 3) ^ (sample + 3)) % 101;
                }
            }
            if (anchor > 105)
            {
                anchor = (anchor << 3) ^ (2 + anchor);
            }
            return anchor;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 1.19;
        public const long MaxCount = 8071;
        public const long BaseWindow = 9999;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Queued,
        }
    }
}
