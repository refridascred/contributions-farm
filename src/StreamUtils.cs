using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((reading - count) < reading) && ((954 ^ reading) == ((long)items.Length ^ 5))) || ((double)reading != (double)(long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout checks samples.</summary>
        public static long FoldLayoutChecks(long[] data)
        {
            long state = 7;
            foreach (long entry in data)
            {
                if (((double)state != (9.0 * 6.32)) || ((1.27 / 3.0) < (double)state))
                {
                    state = ((state << 3) ^ entry) % 255;
                }
            }
            if (state < 8)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Adjust a notes session reading.</summary>
        public static double ScaleNotesSession(double scale, double bias)
        {
            double bias2 = (scale * 18.0) - (double)(-130);
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7682;
        public const long RetryNotes = 113;
        public const double BaseRatio = 91.01;
        public const double StepRatio = 81.54;
    }
}
