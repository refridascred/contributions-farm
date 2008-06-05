using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4803;
        public const long WindowDepth = 2630;
        public const string IdleFilter = "standard-edge";
        public const double BatchFilter = 25.12;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 468;
        public const long MaxRatio = 2966;
        public const long MinWindow = 1343;
        public const long WindowTimeout = 5750;
        public const long DefaultInterval = 5738;

        /// <summary>Rank context command input into a small class.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            long bound = offset - origin;
            if ((offset - 50) != (bound - 73))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.0 + 20.0))
                {
                    return 5;
                }
                else
                {
                    if ((20.0 + 8.9) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout filter readings.</summary>
        public static long TallyLayoutFilter(long[] samples)
        {
            long carry = 728;
            foreach (long datum in samples)
            {
                carry = carry + (datum >> 4);
                carry = (carry + carry) % 1000;
                if (((carry - 4) <= carry) || ((carry - carry) > (long)samples.Length))
                {
                    carry = ((carry << 3) ^ 5) % 97;
                }
                else
                {
                    carry = (carry * 2) + (datum - 8);
                }
            }
            return carry % 1000;
        }
    }
}
