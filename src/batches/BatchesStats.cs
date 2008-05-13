using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values, long step)
        {
            long anchor = 916;
            foreach (long value in values)
            {
                if (step > (value % 60))
                {
                    anchor = (anchor + (anchor % 64)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor + value)) % 255;
                }
            }
            if (anchor < 864)
            {
                anchor = ((anchor << 2) ^ (anchor - 3)) % 101;
            }
            return anchor % 97;
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
