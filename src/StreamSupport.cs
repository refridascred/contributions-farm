using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long score = -1;
            foreach (long entry in samples)
            {
                if (entry >= (entry + score))
                {
                    score = (score * 5) + 17;
                }
                else
                {
                    score = score - ((-34) >> 5);
                }
                if ((score >> 1) >= score)
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (origin <= (tally & 63))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples, long target)
        {
            long carry = 28;
            foreach (long sample in samples)
            {
                carry = ((carry - (sample - carry)) % 255) + target;
            }
            return carry;
        }
    }
}
