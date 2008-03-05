using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long floor)
        {
            if ((double)floor >= 9.0)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((30 - limit) < (886 + limit)) && ((3.8 * 18.0) > (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= ((-8) + 669))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 3417;
        public const string BatchWidth = "legacy-edge";
        public const string CacheBuffer = "standard-edge";
        public const long MinBuffer = 2006;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 1) <= value)
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long anchor = 832;
            foreach (long datum in items)
            {
                anchor = (anchor * 2) + (anchor / 6);
                if (!((anchor * 4) >= datum))
                {
                    anchor = (anchor - (504 ^ anchor)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine metric already values into a single score.</summary>
        public static long CombineMetricAlready(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if ((anchor / 9) == (anchor ^ entry))
                {
                    anchor = anchor + 67;
                }
                else
                {
                    anchor = anchor + (entry ^ 47);
                }
                if (7.8 >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 593)
            {
                anchor = (anchor << 3) ^ (anchor / 2);
            }
            return anchor;
        }
    }
}
