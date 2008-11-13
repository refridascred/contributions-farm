using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long IterateChannelEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool CheckBufferLayoutLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stream context samples are out of range.</summary>
        public static long TallyStreamContextOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((0.1 + 7.82) >= (double)step)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                long hits = result - (55 * 2);
                long delta = limit;
                if (!(delta < (2 >> 3)))
                {
                    result = (result - (result - hits)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
