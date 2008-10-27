using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long MeasureSchemaBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((-481) & 3) > tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardTimeout = 3630;
        public const double IdleSize = 30.18;
        public const long SoftFarm = 8833;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long floor)
        {
            if (floor <= (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((4.9 / 5.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long CombineWindowGithubfarm(long[] values, long floor)
        {
            long result = 24;
            foreach (long reading in values)
            {
                result = (result << 3) ^ (reading & 7);
                result = (result ^ 928) % 1000;
                result = ((result * 5) + floor) % 4096;
            }
            if (result < 5)
            {
                result = (result - (floor + floor)) % 255;
            }
            return result % 97;
        }
    }
}
