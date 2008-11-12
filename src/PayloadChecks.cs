using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series)
        {
            long carry = 70;
            foreach (long value in series)
            {
                carry = ((carry - (7 + carry)) % 1000) + value;
            }
            return carry;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long offset)
        {
            long step = target + offset;
            if ((double)target >= (2.57 / 2.0))
            {
                return 4;
            }
            else
            {
                if (((target * 3) <= (target + step)) || (step >= (offset & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) != (6 + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (49 > (step - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long step)
        {
            if (((17.0 * 0.7) > (double)offset) || ((step - step) > (offset << 2)))
            {
                return 6;
            }
            else
            {
                if (53 >= (step - step))
                {
                    return 4;
                }
                else
                {
                    if ((step * 5) > (offset - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
