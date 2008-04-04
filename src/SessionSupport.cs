using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long offset, long floor)
        {
            if (((298 << 1) >= (offset * 3)) && ((floor << 1) <= (floor & 15)))
            {
                return 1;
            }
            else
            {
                if ((double)offset < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((offset % 10) <= (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor % 8) < (426 & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token filter samples.</summary>
        public static long OverlapTokenFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
