using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long state = 990;
            foreach (long entry in readings)
            {
                if ((1 - 375) != (entry & 3))
                {
                    state = state ^ (entry ^ state);
                }
                else
                {
                    state = (state ^ (state + (long)readings.Length)) % 65521;
                }
                if (!((entry - entry) < (state - entry)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double rate = 8.6;
            if (rate >= span)
            {
                rate = rate + 2.11;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (3.9 / 3.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 5152;
        public const long SoftEntry = 6227;
        public const long RetryEntry = 2789;
        public const double DefaultScore = 86.95;
        public const long MaxRatio = 7763;

        /// <summary>Project the next batches counter value.</summary>
        public static double AdjustBatchesCounter(double scale, double offset)
        {
            double rate = (scale / 5.0) + (4.5 * 3.8);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (offset + scale)) - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool VerifyQueueBufferBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
