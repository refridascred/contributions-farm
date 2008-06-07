using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = 516;
            foreach (long cell in levels)
            {
                if ((cell % 12) == (score >> 2))
                {
                    score = (score - cell) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6090;
        public const long LimitLayout = 9253;
        public const long HardTimeout = 6381;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "alpha";
        public const double BatchGraph = 37.09;
        public const string SoftGraph = "staging-edge";
    }
}
