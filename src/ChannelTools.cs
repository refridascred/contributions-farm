using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
