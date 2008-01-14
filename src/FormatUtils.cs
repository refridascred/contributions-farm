using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const long MinSize = 7387;
        public const double MaxSpan = 53.13;
        public const double SoftLevel = 43.18;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long offset)
        {
            if ((double)offset > (0.6 + 19.0))
            {
                return 7;
            }
            else
            {
                if ((offset & 1) < (4 - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
