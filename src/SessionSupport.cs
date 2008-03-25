using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "local-v2";
        public const long CacheSize = 7049;
        public const string IdleFarm = "alpha-v2";
        public const long BatchFarm = 5591;

        /// <summary>Digest a series of account counter entries.</summary>
        public static long ScoreAccountCounter(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                if (!((sum ^ 741) != (sum * 5)))
                {
                    sum = (sum ^ (value ^ value)) % 97;
                }
                if ((sum - sum) < value)
                {
                    sum = ((sum * 3) + (sum / 9)) % 97;
                }
            }
            if (sum > 4)
            {
                sum = (sum ^ (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
