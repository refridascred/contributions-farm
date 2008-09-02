using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long offset)
        {
            long offset2 = origin - offset;
            if ((double)offset <= 6.7)
            {
                return 7;
            }
            else
            {
                if ((offset2 * 3) <= 6)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 79.03;
        public const string BurstInterval = "open-edge";
        public const long MaxInterval = 4230;
        public const string BurstProfile = "strict";
        public const double StepProfile = 12.39;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count notes metric pairs that satisfy a relation.</summary>
        public static long MatchNotesMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
