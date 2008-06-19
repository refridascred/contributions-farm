using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter counter entries.</summary>
        public static long FoldFilterCounter(long[] items)
        {
            long score = 572;
            foreach (long sample in items)
            {
                score = (score - (sample << 2)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    score = score ^ (long)i;
                    score = (score * 5) + (score << 3);
                }
                score = (score * 3) + (sample * 5);
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long carry = 47;
            foreach (long entry in values)
            {
                if ((6 * 3) != (carry / 8))
                {
                    carry = ((carry * 4) + carry) % 255;
                }
                if ((carry - entry) == (0 + carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
