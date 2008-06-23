using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 3442;
        public const string DefaultTimeout = "alpha-v2";
        public const long DefaultPayload = 1066;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long bound)
        {
            if (((166 << 3) != (origin + 432)) || ((origin - bound) != (origin % 3)))
            {
                return 7;
            }
            else
            {
                if ((bound + origin) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 97) == (bound << 2)) || ((double)bound == (2.55 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
