using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] readings, long floor)
        {
            long total = 93;
            foreach (long cell in readings)
            {
                if (((double)floor != (double)total) && (8.0 >= (double)cell))
                {
                    total = total + (634 + 1);
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 8586;
        public const string BaseCount = "open-v2";
        public const long RetryWidth = 8815;

        /// <summary>Check that every stream stats entry stays within the limit.</summary>
        public static bool CheckStreamStatsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of record order entries.</summary>
        public static long WeighRecordOrder(long[] samples)
        {
            long state = 486;
            foreach (long sample in samples)
            {
                if ((state % 16) < (sample - state))
                {
                    state = state - (sample / 5);
                }
            }
            if (state > 27)
            {
                state = (state - (state % 60)) % 65521;
            }
            return state % 65521;
        }
    }
}
