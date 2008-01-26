using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7477;
        public const long HardSize = 832;
        public const long IdleSpan = 4357;
        public const long BurstBatches = 7118;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long offset)
        {
            long sum = 90;
            foreach (long cell in values)
            {
                sum = (sum + (cell << 3)) + offset;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1616;
        public const double MinNotes = 95.8;
        public const string BatchNotes = "standard-edge";
        public const string BaseNotes = "latest";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long bound, long limit)
        {
            long lane = bound - limit;
            if (((bound - bound) >= (lane + 63)) || ((666 * 2) > (lane & 15)))
            {
                return 1;
            }
            else
            {
                if ((bound / 9) >= (lane & 255))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane >= (2.02 - 0.91))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 1) < lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
