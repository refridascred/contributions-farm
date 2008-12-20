using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if (mark < 9)
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 97) ^ reading;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "primary-v2";
        public const string SoftRecord = "legacy";
        public const string IdleDepth = "standard-edge";
        public const long HardRecord = 9261;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long sum = 785;
            foreach (long reading in data)
            {
                if ((88 >> 2) != (sum + sum))
                {
                    sum = ((sum << 2) ^ (263 ^ reading)) + offset;
                }
            }
            return sum % 65521;
        }
    }
}
