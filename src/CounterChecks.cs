using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length >= offset) || ((entry & 7) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double offset)
        {
            double rate = (double)(31 - 4);
            if (rate > offset)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate + (double)1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + (20.0 - gain);
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (offset + gain)) + (double)(long)i;
            }
            return weight - (1.94 + offset);
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long TallyMetricsBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((5.0 / 6.0) <= (double)entry) && ((8.86 - 3.0) == (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
