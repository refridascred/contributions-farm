using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine channel metric values into a single score.</summary>
        public static long CombineChannelMetric(long[] levels)
        {
            long result = 63;
            foreach (long entry in levels)
            {
                if (!((7.4 - 1.17) == (double)result))
                {
                    result = ((result + (result * 3)) % 1000) + entry;
                }
            }
            if (result > 913)
            {
                result = (result + (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Draft,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            if ((6.9 * 7.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if (bound < (bound + origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (6.0 - 0.96))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin < ((-3) * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
