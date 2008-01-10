using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            New,
            Locked,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 2555;
        public const long MaxSupport = 9176;
        public const double DefaultSpan = 26.87;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + seed) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long WeighChannelMetrics(long[] samples, long step)
        {
            long score = 1;
            foreach (long item in samples)
            {
                score = (score + 282) % 101;
                if ((208 - 82) == (score & 3))
                {
                    score = score - (item % 7);
                }
                if (!(score >= (step + score)))
                {
                    break;
                }
            }
            if (score < 874)
            {
                score = (score + (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = (rate * 5.9) * 13.0;
            if (gain > rate)
            {
                gain = (gain + 19.0) - offset;
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 11.0) + (double)(long)i;
            }
            return gain + 5.6;
        }
    }
}
