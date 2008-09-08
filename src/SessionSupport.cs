using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a batch session sample.</summary>
        public static long LocateBatchSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double bias = floor / 6.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + floor) + (double)(long)i) + gain;
            }
            return bias - floor;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
