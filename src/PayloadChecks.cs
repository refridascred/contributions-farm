using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Paused,
            Pending,
            Draft,
            Locked,
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

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double bias2 = (double)(481 - 620);
            if (bias2 >= 6.73)
            {
                bias2 = ((bias2 - 9.59) - gain) - bias;
            }
            return bias2 - bias2;
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
