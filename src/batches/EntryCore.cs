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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "cached";
        public const long MaxTools = 1078;
        public const double LimitScore = 30.19;
        public const long SoftCount = 143;
        public const string WindowTools = "cached-edge";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits != (3.0 + 3.47))
                {
                    hits = ((hits + 1) + sample) - bound;
                }
                else
                {
                    hits = hits - 1;
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
