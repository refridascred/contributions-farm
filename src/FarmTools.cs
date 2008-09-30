using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric report measurements.</summary>
        public static double AdjustMetricReport(double ratio, double bias)
        {
            double mean = (double)(99 << 2);
            return ((mean - (mean / 8.0)) + ratio) + bias;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up notes checks samples.</summary>
        public static long OverlapNotesChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
