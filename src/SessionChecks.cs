using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
