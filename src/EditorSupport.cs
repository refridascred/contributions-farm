using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double scale = bias - (11.0 + 4.98);
            return (scale + bias) + weight;
        }

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool GuardCounterPayloadBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the queue batches entries that pass the check.</summary>
        public static long AuditQueueBatchesHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count > (2.8 - 18.0))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor - 66) == (730 + 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
