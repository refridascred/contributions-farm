using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double ScaleCommandSupport(double ratio, double span)
        {
            double scale = (span / 9.0) - (span + ratio);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + 19.0;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
