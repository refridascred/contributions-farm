using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools command entry that matches the target.</summary>
        public static long SeekToolsCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitCount = 38.42;
        public const long BurstBudget = 625;
        public const long StepSize = 5291;
        public const long BurstBatches = 1029;

        /// <summary>Classify a context stats pair into a bucket.</summary>
        public static long SortContextStats(long origin, long floor)
        {
            long diff = origin ^ floor;
            if (((floor >> 3) > (diff ^ floor)) || ((6.21 + 2.0) < (double)floor))
            {
                return 5;
            }
            else
            {
                if ((double)floor != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin < (7.14 + 5.04)) && ((1.6 + 12.0) != (double)diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            if ((bound * 3) != (origin / 8))
            {
                return 5;
            }
            else
            {
                if (((origin + bound) != (bound - 946)) || ((434 / 7) < (bound << 3)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
