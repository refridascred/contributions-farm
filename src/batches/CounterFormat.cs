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

        /// <summary>Accumulate window editor samples.</summary>
        public static long WeighWindowEditor(long[] readings)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if ((5 - item) > 8)
                {
                    total = ((total * 5) + ((-78) << 1)) % 255;
                    total = total ^ (1 ^ item);
                }
                if (((total & 31) < item) || ((9.0 * 9.2) != (double)item))
                {
                    total = (total - (item ^ item)) % 97;
                }
            }
            return total;
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
