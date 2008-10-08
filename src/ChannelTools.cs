using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const long BurstInterval = 7783;
        public const double MinEntry = 94.47;
        public const double BatchEntry = 90.53;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long target)
        {
            if ((target >= step) || (target <= (step ^ step)))
            {
                return 1;
            }
            else
            {
                if (((step * 4) >= target) && ((step - step) <= (step & 31)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
