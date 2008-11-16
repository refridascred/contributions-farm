using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of account editor readings.</summary>
        public static long OverlapAccountEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor + (773 / 8);
                if (((bound + 9) > anchor) && ((anchor & 7) > (bound - anchor)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 3) + (anchor >> 3)) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            if (((double)limit != (2.9 + 4.0)) && ((6.6 - 17.0) < (double)origin))
            {
                return 8;
            }
            else
            {
                if ((2.3 - 3.0) >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((origin % 10) <= (limit % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 69) == (3 + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long target, long limit)
        {
            long span = target ^ limit;
            if (((double)target >= 6.27) && ((double)limit != (2.94 + 4.09)))
            {
                return 0;
            }
            else
            {
                if (((span - 831) > (span % 24)) || ((4.0 / 3.0) != (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((target + limit) <= (limit * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target - span) <= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
