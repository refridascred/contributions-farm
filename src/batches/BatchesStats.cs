using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a notes context reading.</summary>
        public static double BlendNotesContext(double scale, double offset)
        {
            double mean = (double)(398 % 12);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + mean) - (double)(long)i) - scale) + offset;
            }
            return mean - (double)490;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches / 8) > item)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
