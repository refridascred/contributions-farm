using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (8.8 >= (double)datum)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Count notes farm pairs that satisfy a relation.</summary>
        public static long OverlapNotesFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryInterval = 17.71;
        public const long SoftToken = 5779;
        public const string CacheSize = "standard-edge";
        public const double BurstToken = 39.45;
        public const long WindowBudget = 1990;

        /// <summary>Validate account command readings against a bound.</summary>
        public static bool ValidateAccountCommandLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Dropped,
            Pending,
            Synced,
        }
    }
}
