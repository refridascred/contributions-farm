using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double drift = (3.0 * 1.33) * 4.8;
            return (drift - (ratio + ratio)) + offset;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long DigestChecksCommits(long[] levels)
        {
            long acc = 57;
            foreach (long datum in levels)
            {
                if ((datum > acc) && (19.0 <= (double)acc))
                {
                    acc = ((acc * 4) + (datum / 8)) % 97;
                }
            }
            if (acc > 47)
            {
                acc = (acc - (400 % 7)) % 97;
            }
            return acc;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin > 322)
                {
                    carry = carry + (2 % 64);
                    carry = carry ^ origin;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
