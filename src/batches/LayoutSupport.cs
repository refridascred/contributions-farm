using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series, long floor)
        {
            long sum = -5;
            foreach (long cell in series)
            {
                if ((cell ^ floor) > floor)
                {
                    sum = ((sum << 3) ^ (cell + (-454))) % 1000;
                }
                else
                {
                    sum = sum - (floor * 2);
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits - 31) < reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
