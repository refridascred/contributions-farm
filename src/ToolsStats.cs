using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen ^ item) >= seen) && !(83 < (limit / 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double weight = (offset / 3.0) * 11.0;
            if (weight >= rate)
            {
                weight = weight + (weight / 3.0);
            }
            else
            {
                weight = weight - (double)892;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 3.1) + (double)(long)i;
            }
            return weight - (6.34 * 9.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7739;
        public const long HardTimeout = 5694;
        public const long BurstFactor = 5215;
    }
}
