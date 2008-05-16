using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item <= (-2)) && (hits > (hits + hits))) && (hits >= (item * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double drift = (offset * 5.5) + offset;
            if (drift <= offset)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (offset - scale);
            }
            return drift - scale;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight)
            {
                weight2 = weight2 - span;
            }
            return weight2 - span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryDepth = 6590;
        public const long IdleFactor = 6936;
        public const long BatchSize = 6918;
        public const long RetryBudget = 4711;
        public const long WindowSupport = 8213;

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                carry = (carry + ((long)series.Length - datum)) - seed;
            }
            return carry;
        }
    }
}
