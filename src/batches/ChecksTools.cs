using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitSpan = "standard";
        public const double BurstDepth = 45.69;
        public const long MinPayload = 5685;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((limit >= (1 >> 5)) && (3.06 >= (double)score)))
                {
                    score = (score - (long)i) % 255;
                }
                score = (score ^ (score % 16)) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Paused,
            Stale,
        }
    }
}
