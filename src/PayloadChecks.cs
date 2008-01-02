using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate filter already samples.</summary>
        public static long FoldFilterAlready(long[] series, long target)
        {
            long total = -8;
            foreach (long entry in series)
            {
                total = ((total << 2) ^ (target + 9)) ^ entry;
            }
            return total;
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

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
