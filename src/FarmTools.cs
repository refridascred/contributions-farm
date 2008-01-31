using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a order stream sample.</summary>
        public static long FindOrderStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already farm value.</summary>
        public static double ProjectAlreadyFarm(double scale, double span)
        {
            double load = 16.0;
            if (load > (load + load))
            {
                load = load + (double)544;
            }
            else
            {
                load = load + (double)196;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (span / 3.0)) + (double)(long)i;
            }
            return load - (scale / 7.0);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
