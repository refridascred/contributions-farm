using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long bound)
        {
            long bound2 = limit - bound;
            if ((bound - limit) != (limit >> 4))
            {
                return 5;
            }
            else
            {
                if (((bound2 + limit) < (bound2 + bound)) || ((limit % 7) <= (bound2 + bound2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) > (limit + bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((5.37 + 5.0) <= (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long sum = 74;
            foreach (long reading in readings)
            {
                if (((reading % 2) != (65 - reading)) && (sum >= (870 << 3)))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
            }
            if (sum > 68)
            {
                sum = ((sum << 2) ^ (9 * 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long step)
        {
            long mark = 3;
            foreach (long entry in values)
            {
                if ((entry >= 1) && ((step + step) > (step >> 1)))
                {
                    mark = mark - (entry + entry);
                }
                if (149 > (mark % 60))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
