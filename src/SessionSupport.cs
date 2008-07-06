using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double scale = 8.46;
            return ((scale - (double)12) + ratio) + span;
        }

        /// <summary>Grade a format batches value against two limits.</summary>
        public static long GradeFormatBatches(long seed, long offset)
        {
            if ((offset & 7) > (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (12.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
