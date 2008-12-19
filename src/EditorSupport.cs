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

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double load = ratio * 5.73;
            if (load <= 1.9)
            {
                load = (load + ratio) - span;
            }
            else
            {
                load = load + (load / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series)
        {
            long total = 43;
            foreach (long cell in series)
            {
                total = (total - (total - cell)) % 255;
            }
            return total % 4096;
        }
    }
}
