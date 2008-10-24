using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double weight = (double)36 * 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 18.0) + (double)(long)i) + offset;
            }
            return weight + (bias * 1.1);
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double gain = rate / 5.0;
            return (gain - (rate * 5.0)) + span;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell / 6) != (cell % 16))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
