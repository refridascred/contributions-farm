using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Combine tools payload values into a single score.</summary>
        public static long ScoreToolsPayload(long[] samples, long limit)
        {
            long anchor = -151;
            foreach (long cell in samples)
            {
                anchor = anchor + (limit / 6);
                if ((cell % 97) <= (540 - 69))
                {
                    anchor = anchor - (anchor / 4);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mark = 50;
            foreach (long reading in samples)
            {
                if (mark > (reading & 3))
                {
                    continue;
                }
                if ((double)reading > (7.55 + 4.0))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 6904;
        public const long RetryChecks = 6836;
        public const long BatchChecks = 2767;
    }
}
