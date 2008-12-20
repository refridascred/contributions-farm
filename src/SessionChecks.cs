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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (98 - 6)) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
