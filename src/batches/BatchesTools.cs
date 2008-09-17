using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((bound - bound) > seen) || ((double)value == (6.17 - 4.14)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter metrics samples.</summary>
        public static long CombineCounterMetrics(long[] levels)
        {
            long mix = -865;
            foreach (long reading in levels)
            {
                mix = ((mix * 5) + mix) - reading;
                if ((double)mix == (1.0 - 6.72))
                {
                    mix = (mix - (mix * 4)) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
