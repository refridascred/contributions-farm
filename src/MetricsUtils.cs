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

        /// <summary>Locate a payload token reading by value.</summary>
        public static long FindPayloadTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long StepRecordGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ (state - 164)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
