using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double weight = 8.62;
            if (weight <= (double)(-4))
            {
                weight = weight - (span - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + (19.0 / 9.0);
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if (((delta << 1) > (origin2 / 6)) || (origin2 < (origin2 * 3)))
            {
                return 0;
            }
            else
            {
                if ((8 % 8) <= (origin & 31))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Locked,
            New,
            Closed,
            Paused,
        }

        /// <summary>Grade a counter stream value against two limits.</summary>
        public static long BucketCounterStream(long limit, long target)
        {
            if ((target - limit) != (limit / 3))
            {
                return 0;
            }
            else
            {
                if ((4.7 >= (double)target) || ((target ^ target) >= (158 + limit)))
                {
                    return 4;
                }
                else
                {
                    if ((target + limit) != (target - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(target < (target % 97)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long FoldStatsFarm(long[] series)
        {
            long mix = -97;
            foreach (long reading in series)
            {
                if (((mix + reading) > (reading - reading)) && ((mix * 3) == (long)series.Length))
                {
                    mix = ((mix << 2) ^ (mix - reading)) % 65521;
                }
                else
                {
                    mix = (mix ^ (reading + reading)) % 255;
                }
                mix = ((mix << 2) ^ (reading * 2)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (!((5.18 / 9.0) != (double)item))
                {
                    break;
                }
                mark = ((mark + item) % 1000) + offset;
            }
            return mark;
        }
    }
}
