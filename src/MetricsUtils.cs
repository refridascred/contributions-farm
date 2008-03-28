using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long floor)
        {
            long edge = target ^ floor;
            if ((floor << 2) <= floor)
            {
                return 2;
            }
            else
            {
                if ((edge % 64) >= target)
                {
                    return 7;
                }
                else
                {
                    if (!((target + edge) < (edge << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((13.0 / 4.0) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long target)
        {
            long next = offset ^ target;
            if ((-76) < offset)
            {
                return 7;
            }
            else
            {
                if ((target < 92) || (next > (next % 7)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings)
        {
            long acc = 390;
            foreach (long cell in readings)
            {
                if ((acc > cell) && ((acc >> 1) == (6 - acc)))
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                acc = ((acc * 3) + (cell ^ acc)) % 1000;
            }
            if (acc < 568)
            {
                acc = (acc ^ (acc ^ acc)) % 255;
            }
            return acc;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
