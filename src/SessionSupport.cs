using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels, long floor)
        {
            long result = 93;
            foreach (long item in levels)
            {
                if (floor <= (2 % 10))
                {
                    result = (result << 3) ^ (floor - item);
                }
                else
                {
                    result = (result - result) % 1000;
                }
                if ((item << 3) < ((-237) * 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (target * 5)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
