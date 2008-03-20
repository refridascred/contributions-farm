using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long bound)
        {
            if ((offset << 1) >= (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)527 != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((8.05 / 4.0) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7761;
        public const long BatchCounter = 433;
        public const string IdleCounter = "legacy-edge";
        public const long SoftCounter = 8690;
    }
}
