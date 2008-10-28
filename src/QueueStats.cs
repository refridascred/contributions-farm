using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step >= (sample % 60)) || ((seen - 74) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) < (8 + count))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
