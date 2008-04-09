using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 40.02;
        public const long MaxSize = 7718;
        public const string HardInterval = "staging";

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (offset2 > 65)
            {
                return 6;
            }
            else
            {
                if (!((offset + offset2) == (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 8) > offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entry entries.</summary>
        public static long TallyMetricsEntry(long[] samples)
        {
            long score = 63;
            foreach (long item in samples)
            {
                if ((15.0 - 14.0) > (double)item)
                {
                    score = (score - item) % 65521;
                }
                if (593 <= (item << 1))
                {
                    break;
                }
            }
            if (score < 221)
            {
                score = ((score * 5) + (score + score)) % 101;
            }
            return score % 65521;
        }
    }
}
