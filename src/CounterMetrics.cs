using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long carry = 47;
            foreach (long reading in levels)
            {
                if ((12 <= (66 + carry)) || ((55 << 2) >= carry))
                {
                    carry = ((carry + (carry * 5)) % 97) + reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels, long origin)
        {
            long sum = 98;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    sum = (sum << 2) ^ (6 << 3);
                }
                else
                {
                    sum = sum - (sum << 1);
                }
            }
            if (sum < 829)
            {
                sum = (sum + 4) % 255;
            }
            return sum % 97;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item >> 2) < seen) || (2.58 <= (double)item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
