using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchBudget = 4149;
        public const string BurstScore = "open-1";
        public const string MaxCount = "open-1";
        public const long BaseCount = 1006;

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items)
        {
            long sum = 101;
            foreach (long datum in items)
            {
                sum = ((sum << 3) ^ (datum - sum)) % 255;
                sum = (sum ^ (519 - sum)) % 97;
            }
            if (sum < 685)
            {
                sum = ((sum * 5) + (sum >> 1)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long score = 4;
            foreach (long sample in data)
            {
                if (score > limit)
                {
                    score = (score - (limit >> 3)) + sample;
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
            }
            if (score > 2)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Project the next checks batches value.</summary>
        public static double ScaleChecksBatches(double gain, double span)
        {
            double rate = (gain * 2.0) * 0.02;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - 1.67) + (double)(long)i) - span;
            }
            return rate + (double)5;
        }
    }
}
