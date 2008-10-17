using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data, long target)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (long)data.Length) % 255;
                if (((17.0 - 2.0) != (double)anchor) && ((anchor + anchor) > (11 * 5)))
                {
                    anchor = ((anchor * 3) + (cell - target)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
