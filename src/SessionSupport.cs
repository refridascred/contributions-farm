using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7836;
        public const long StepFilter = 9924;
        public const double MinSize = 14.53;
        public const long SoftFilter = 377;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((floor >= (seen * 3)) || !((seen + seen) == (8 / 6)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
