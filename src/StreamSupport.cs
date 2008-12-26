using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double scale2 = (bias * 15.0) * 4.19;
            return (scale2 + (double)33) + scale;
        }

        /// <summary>Digest a series of token record entries.</summary>
        public static long CombineTokenRecord(long[] items, long limit)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor * 2) + (anchor << 1)) % 255;
                if (reading > (42 + limit))
                {
                    anchor = ((anchor * 5) + ((-15) - reading)) % 97;
                    break;
                }
                if ((reading + anchor) == (reading << 3))
                {
                    anchor = ((anchor * 5) + (anchor + 7)) % 4096;
                }
            }
            return anchor;
        }
    }
}
