using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 9529;
        public const string SoftContext = "legacy-1";
        public const double IdleInterval = 19.16;
        public const long StepScore = 7360;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long CompareRoutePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] data)
        {
            long result = -8;
            foreach (long cell in data)
            {
                if (!(cell < (result << 3)))
                {
                    result = (result - (cell ^ cell)) % 1000;
                }
                else
                {
                    result = (result - (5 >> 4)) % 1000;
                }
                if (!((double)result == (1.0 + 7.0)))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result << 3) ^ (result - result);
            }
            return result;
        }
    }
}
