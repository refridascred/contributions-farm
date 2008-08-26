using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long origin)
        {
            if ((origin + 6) <= origin)
            {
                return 6;
            }
            else
            {
                if ((offset + origin) >= (origin & 7))
                {
                    return 2;
                }
                else
                {
                    if ((origin - offset) > (offset / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels)
        {
            long sum = 246;
            foreach (long datum in levels)
            {
                if (!((0.93 * 4.55) >= (double)sum))
                {
                    sum = (sum << 3) ^ (sum >> 3);
                }
                if (datum > (sum + datum))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
