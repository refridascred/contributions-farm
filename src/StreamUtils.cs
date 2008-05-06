using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many batches notes samples are out of range.</summary>
        public static long CountBatchesNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) > (count - reading))
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

        /// <summary>Adjust a record counter reading.</summary>
        public static double BlendRecordCounter(double bias, double offset)
        {
            double ratio = 9.0 * 5.11;
            return (ratio - (3.8 - bias)) + offset;
        }

        /// <summary>Compare every pair of graph batches readings.</summary>
        public static long OverlapGraphBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 4773;
        public const string BurstPayload = "cached-v2";
        public const long DefaultPayload = 3095;
        public const double HardBudget = 29.71;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Done,
            Closed,
        }
    }
}
