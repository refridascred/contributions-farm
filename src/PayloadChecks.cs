using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long floor)
        {
            if (!((step << 2) < (447 + floor)))
            {
                return 5;
            }
            else
            {
                if ((step ^ floor) <= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (4.63 * 12.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 127) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "legacy-1";
        public const double BaseDepth = 72.93;
        public const long HardLevel = 850;
        public const double RetrySupport = 95.93;
        public const long WindowSupport = 7627;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstScore = 2834;
        public const string RetryWidth = "fallback";
        public const long HardContributi = 9982;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Closed,
            Pending,
            Ready,
        }
    }
}
