using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long result = 376;
            foreach (long datum in values)
            {
                if ((datum + result) == (datum + 36))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 92.99;
        public const string MinTools = "standard-edge";
        public const long IdleSize = 7014;

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = 1;
            foreach (long value in series)
            {
                score = (score - (score + value)) % 255;
                if ((score << 3) != (score + score))
                {
                    break;
                }
            }
            if (score < (-22))
            {
                score = (score * 4) + (score - score);
            }
            return score % 97;
        }
    }
}
