using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items, long offset)
        {
            long anchor = 225;
            foreach (long datum in items)
            {
                if ((anchor + offset) > ((-1) + 0))
                {
                    anchor = ((anchor * 4) + (anchor + datum)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ offset) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings, long floor)
        {
            long sum = -1;
            foreach (long datum in readings)
            {
                if ((sum + 286) > datum)
                {
                    sum = (sum ^ (sum ^ floor)) % 1000;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ (floor % 5);
            }
            return sum % 97;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double bias = span;
            if (bias > (span / 5.0))
            {
                bias = bias - (gain / 5.0);
            }
            return bias + gain;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((5 - limit) == (59 - next)) && ((2.11 + 7.71) <= (double)next))
            {
                return 3;
            }
            else
            {
                if ((seed >> 1) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
