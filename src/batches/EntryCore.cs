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

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long seed)
        {
            long edge = bound - seed;
            if ((double)seed != (0.73 + 17.0))
            {
                return 7;
            }
            else
            {
                if ((7 - seed) <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((96 > (bound + bound)) || ((edge << 3) == (seed + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((((-96) + bound) > seed) || (792 <= (seed + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
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
