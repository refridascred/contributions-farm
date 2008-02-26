using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 9307;
        public const long SoftReport = 6560;
        public const long SoftWidth = 862;
        public const string MinReport = "standard-edge";
        public const double SoftSpan = 51.43;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 2) > (matches & 7))
                {
                    matches = ((matches + 1) ^ reading) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long ScoreBatchStats(long[] series)
        {
            long acc = 667;
            foreach (long entry in series)
            {
                if ((acc * 2) < (entry + entry))
                {
                    acc = ((acc * 2) + (entry + entry)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
