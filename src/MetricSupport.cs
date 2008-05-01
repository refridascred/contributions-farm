using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFactor = 6358;
        public const double IdleFarm = 78.85;
        public const double BatchCount = 6.08;

        /// <summary>Digest a series of command support entries.</summary>
        public static long FoldCommandSupport(long[] samples)
        {
            long acc = 512;
            foreach (long reading in samples)
            {
                acc = (acc ^ (20 ^ reading)) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TallyStreamContext(long[] samples, long target)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                carry = ((carry * 5) + (datum + datum)) % 1000;
                if (!((double)datum > (13.0 / 7.0)))
                {
                    carry = (carry - (target >> 1)) % 1000;
                }
            }
            return carry;
        }
    }
}
