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

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long origin)
        {
            if ((1.5 > (double)origin) && ((origin ^ origin) != (origin & 31)))
            {
                return 6;
            }
            else
            {
                if (!((origin + 769) >= 0))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ bound) >= (origin + 91))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 5) < bound) || (origin >= (bound - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
