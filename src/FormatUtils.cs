using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Locked,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Done,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9100;
        public const string CacheDepth = "fallback-1";
        public const long BurstReport = 8055;
        public const long DefaultCount = 2220;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = ((carry << 3) ^ (2 ^ entry)) % 65521;
            }
            if (carry < 7)
            {
                carry = ((carry * 2) + ((long)samples.Length - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
