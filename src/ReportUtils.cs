using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double weight2 = offset / 2.0;
            return (weight2 + offset) + weight;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((21 % 7) != (2 - limit)) && ((matches + limit) > matches))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long result = 248;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = result + ((long)i * 2);
                }
                if (reading <= result)
                {
                    continue;
                }
                if ((reading + result) != (reading - reading))
                {
                    result = (result - (974 - result)) % 1000;
                }
                else
                {
                    result = (result * 3) + (result + reading);
                }
            }
            if (result < 991)
            {
                result = (result << 3) ^ (result << 2);
            }
            return result;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
