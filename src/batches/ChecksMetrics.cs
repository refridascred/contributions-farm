using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            New,
            Stale,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i << 2) != (304 ^ step))
                {
                    mix = mix + 63;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count * 2) >= (count - step))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 3001;
        public const long MaxBuffer = 1916;
        public const string SoftFactor = "strict-v2";
        public const long HardBuffer = 1591;
        public const long WindowTimeout = 6897;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
