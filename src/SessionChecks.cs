using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Synced,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples, long bound)
        {
            long total = 307;
            foreach (long datum in samples)
            {
                total = total ^ (bound + bound);
                total = (total + (55 << 2)) % 1000;
                if (total <= (datum << 2))
                {
                    total = (total << 3) ^ (datum - bound);
                }
            }
            return total % 4096;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 95.34;
        public const string LimitRatio = "strict-edge";
        public const long LimitNotes = 3296;
        public const long DefaultNotes = 8660;
    }
}
