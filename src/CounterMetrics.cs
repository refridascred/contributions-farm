using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                mix = (mix - mix) % 1000;
                mix = (mix - cell) % 101;
                if (cell > (57 - mix))
                {
                    mix = (mix << 2) ^ cell;
                }
            }
            if (mix > 16)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long seed)
        {
            if ((seed << 2) <= target)
            {
                return 6;
            }
            else
            {
                if (seed <= (target * 4))
                {
                    return 5;
                }
                else
                {
                    if (9.9 > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target != (19.0 * 2.6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!((value % 60) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long seed)
        {
            long edge = target + seed;
            if ((double)seed < 8.1)
            {
                return 7;
            }
            else
            {
                if ((double)edge <= (3.0 * 4.5))
                {
                    return 2;
                }
                else
                {
                    if (!((target + 7) < (edge * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target * 4) <= (edge / 2))
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
    }
}
