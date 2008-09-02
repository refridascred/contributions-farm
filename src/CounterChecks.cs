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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many contributi metric samples are out of range.</summary>
        public static long TallyContributiMetricHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((278 - tally) < (target - sample)) || ((sample * 5) < (target >> 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
