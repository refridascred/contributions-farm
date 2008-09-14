using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 995;
        public const long WindowSize = 2105;
        public const long IdleReport = 1266;
        public const string RetryReport = "standard-1";
        public const long WindowReport = 3518;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool VerifyCounterBufferLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a support metric reading.</summary>
        public static double SmoothSupportMetric(double bias, double span)
        {
            double drift = (double)8 * 3.1;
            if (drift <= span)
            {
                drift = (drift + (span + 4.05)) + bias;
            }
            else
            {
                drift = drift + (double)60;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 13.0)) + (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
