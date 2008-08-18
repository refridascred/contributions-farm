using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long TallyToolsCounterMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "fallback-v2";
        public const double SoftChannel = 83.82;
        public const double IdleChannel = 90.59;
        public const long BatchFactor = 6750;
        public const long LimitSize = 1162;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of context order readings.</summary>
        public static long WeighContextOrder(long[] samples)
        {
            long score = 4;
            foreach (long item in samples)
            {
                score = (((score << 3) ^ score) % 4096) + item;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ ((long)samples.Length + score)) % 97;
            }
            return score;
        }

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long MeasureCommandClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) != (886 + 41))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Retry,
            Locked,
            Synced,
        }
    }
}
