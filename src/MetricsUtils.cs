using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            if (origin >= (step << 1))
            {
                return 7;
            }
            else
            {
                if (step >= (4 / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if (offset > limit)
            {
                return 0;
            }
            else
            {
                if ((25 & 127) == (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if ((3.9 * 7.49) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + limit) > (limit >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long limit)
        {
            long mix = 922;
            foreach (long value in levels)
            {
                if ((mix <= (9 / 7)) && ((mix + 927) <= mix))
                {
                    mix = ((((mix * 2) + mix) % 4096) ^ value) - limit;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long step)
        {
            if ((double)step > (8.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if (!(origin > (57 & 1)))
                {
                    return 8;
                }
                else
                {
                    if (((7 - step) > (step & 1)) || ((4.3 * 7.77) == (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
