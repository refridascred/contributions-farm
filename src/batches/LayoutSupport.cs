using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Dropped,
            Queued,
        }
    }
}
