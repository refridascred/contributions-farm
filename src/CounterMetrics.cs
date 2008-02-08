using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long seed)
        {
            long carry = -638;
            foreach (long reading in readings)
            {
                carry = (((carry * 5) + 4) % 4096) + reading;
                carry = (carry + (seed * 5)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate route buffer samples.</summary>
        public static long TotalRouteBuffer(long[] samples)
        {
            long total = 835;
            foreach (long cell in samples)
            {
                if ((4.2 * 8.4) == (double)cell)
                {
                    total = (total ^ (total + cell)) % 1000;
                }
            }
            if (total < (-53))
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total;
        }

        /// <summary>Validate farm metrics readings against a bound.</summary>
        public static bool VerifyFarmMetricsLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
