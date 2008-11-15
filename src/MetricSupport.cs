using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples, long seed)
        {
            long mark = 894;
            foreach (long datum in samples)
            {
                if (datum > 6)
                {
                    mark = (mark ^ (7 << 2)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long target)
        {
            long step = origin - target;
            if (((double)step <= (7.0 - 4.72)) && ((6.7 + 7.0) != (double)target))
            {
                return 7;
            }
            else
            {
                if ((step / 6) > (6 % 97))
                {
                    return 2;
                }
                else
                {
                    if ((target >= origin) || ((double)step <= 5.79))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
