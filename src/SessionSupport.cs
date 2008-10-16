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

        /// <summary>Classify a metrics buffer pair into a bucket.</summary>
        public static long ClassifyMetricsBuffer(long limit, long limit2)
        {
            if ((limit >> 4) >= (limit2 * 3))
            {
                return 0;
            }
            else
            {
                if (((limit / 4) > limit) && ((limit2 + limit) > limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit2 + limit2) < ((-74) & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if (98 < (limit2 >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
