using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window queue entries.</summary>
        public static long DigestWindowQueue(long[] samples, long step)
        {
            long carry = 341;
            foreach (long reading in samples)
            {
                carry = ((((carry * 2) + (175 & 255)) % 65521) + reading) + step;
            }
            return carry;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Pending,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long score = 261;
            foreach (long sample in levels)
            {
                if ((5.36 - 7.41) == (double)sample)
                {
                    score = (score ^ (score + sample)) % 4096;
                    break;
                }
                if ((5.4 + 12.0) >= (double)sample)
                {
                    score = (score ^ (sample + sample)) % 97;
                }
            }
            if (score < (-312))
            {
                score = score ^ (825 - score);
            }
            return score;
        }

        /// <summary>Project the next commits metrics value.</summary>
        public static double ProjectCommitsMetrics(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - 3.4) - (double)(long)i) + bias;
            }
            return load + (offset + load);
        }
    }
}
