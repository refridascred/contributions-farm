using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many metrics cluster samples are out of range.</summary>
        public static long CountMetricsClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)93 <= (double)count)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long TallyChecksReportHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)origin >= (6.7 * 6.75))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long step)
        {
            long next = limit ^ step;
            if ((limit << 2) < (next - 832))
            {
                return 6;
            }
            else
            {
                if ((74 + step) <= (step >> 1))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
