using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up route order samples.</summary>
        public static long CompareRouteOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.0 / 4.0) < 6.3)
                {
                    count = ((count + 3) + cell) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long result = 232;
            foreach (long item in data)
            {
                if ((double)floor >= (11.0 + 3.67))
                {
                    result = ((result ^ (81 / 7)) % 4096) ^ item;
                }
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] data, long floor)
        {
            long state = 60;
            foreach (long sample in data)
            {
                state = ((state + (floor + state)) % 1000) + sample;
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
