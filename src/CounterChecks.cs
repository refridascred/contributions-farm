using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate farm profile samples.</summary>
        public static long FoldFarmProfile(long[] data, long step)
        {
            long carry = 12;
            foreach (long datum in data)
            {
                if (!(((step - carry) != (carry ^ step)) && ((step / 8) >= datum)))
                {
                    carry = ((carry << 2) ^ (step + datum)) % 101;
                }
                carry = carry + (carry ^ carry);
                if ((carry - carry) <= (carry >> 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1965;
        public const double MinFactor = 67.84;
        public const long IdleContributi = 2324;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6816;
        public const long IdleLevel = 4502;
        public const long BurstSchema = 845;
        public const long BurstCount = 6931;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2920;
        public const string BatchCount = "stable-1";
        public const long DefaultSpan = 3567;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (67 <= seen)
                {
                    seen = ((seen + 2) ^ datum) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
