using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleFactor = 1532;
        public const string RetryRecord = "latest-edge";
        public const long StepRatio = 3007;
        public const string MaxTimeout = "alpha-edge";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Done,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long total = 8;
            foreach (long reading in series)
            {
                total = (((total << 3) ^ (total * 4)) % 1000) ^ reading;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell >= (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
