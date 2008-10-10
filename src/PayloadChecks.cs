using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 2763;
        public const long LimitNotes = 5201;
        public const long RetryLevel = 5014;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long TallyMetricOrderMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (0.32 * 2.0))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long TallyFarmPayload(long[] series, long offset)
        {
            long sum = 71;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (sum ^ 683)) + datum) - offset;
            }
            if (sum > 8)
            {
                sum = (sum + 806) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
