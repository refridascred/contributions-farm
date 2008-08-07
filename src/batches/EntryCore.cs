using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next support contributi value.</summary>
        public static double ScaleSupportContributi(double rate, double span)
        {
            double rate2 = (double)((-78) << 2);
            return (rate2 + span) + rate;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "cached";
        public const long MaxTools = 1078;
        public const double LimitScore = 30.19;
        public const long SoftCount = 143;
        public const string WindowTools = "cached-edge";

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
