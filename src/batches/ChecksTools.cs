using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)result == (1.44 * 4.5))
                {
                    result = (result - ((long)i + origin)) % 101;
                }
                else
                {
                    result = (result - (-22)) % 65521;
                    result = ((result * 5) + (origin / 2)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
