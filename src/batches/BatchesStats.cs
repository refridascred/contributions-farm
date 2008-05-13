using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double weight = ratio / 3.0;
            if (weight > ratio)
            {
                weight = weight - 9.0;
            }
            return weight - (ratio - span);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Failed,
            Done,
            Active,
        }
    }
}
