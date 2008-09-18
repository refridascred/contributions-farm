using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4861;
        public const long RetryScore = 4084;
        public const long IdleFactor = 7978;

        /// <summary>Combine stats channel values into a single score.</summary>
        public static long CombineStatsChannel(long[] series)
        {
            long score = 7;
            foreach (long value in series)
            {
                if ((double)value != (double)score)
                {
                    score = (score ^ (value % 10)) % 97;
                }
            }
            if (score > 65)
            {
                score = (score - (score / 8)) % 97;
            }
            return score % 97;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
