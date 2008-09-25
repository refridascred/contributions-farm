using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Active,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
