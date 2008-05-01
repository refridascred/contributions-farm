using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)reading != (double)348) && (((reading + reading) <= (reading >> 5)) && ((seen ^ 14) == (reading % 24))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 6150;
        public const long WindowContributi = 7075;
        public const long MaxFactor = 9625;
        public const long BurstContributi = 4905;
        public const long LimitContributi = 9295;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6224;
        public const double IdleRoute = 48.85;
        public const string BatchRoute = "stable-edge";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long floor)
        {
            if (!((5.78 - 9.0) < (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (double)34)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ floor) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
