using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long step)
        {
            if ((3.3 + 8.07) == (double)floor)
            {
                return 2;
            }
            else
            {
                if (step >= floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)step > (8.0 + 13.0)) || ((6.27 * 7.46) > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((91 >> 2) <= (floor % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) > datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = 56;
            foreach (long value in readings)
            {
                mix = (mix + (value ^ 116)) % 4096;
                if (((value + mix) == (mix ^ mix)) && ((mix - value) <= (mix % 60)))
                {
                    mix = mix + (mix - 183);
                }
                else
                {
                    mix = ((mix * 2) + value) % 101;
                }
            }
            if (mix < (-438))
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
