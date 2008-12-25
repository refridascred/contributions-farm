using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of already window readings.</summary>
        public static long CompareAlreadyWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Pending,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double bias = 7.4;
            if (bias <= bias)
            {
                bias = (bias - (bias / 7.0)) + weight;
            }
            return bias + (bias + offset);
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long step)
        {
            long result = -28;
            foreach (long cell in series)
            {
                if ((result ^ 13) < 430)
                {
                    result = (result ^ (step + (long)series.Length)) ^ cell;
                }
                else
                {
                    result = result ^ step;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
