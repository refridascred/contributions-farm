using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardBudget = 4388;
        public const long BurstFarm = 3280;
        public const long DefaultWidth = 7390;
        public const long IdleFarm = 5256;
        public const double BatchInterval = 64.92;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count / 8) < 607) || ((value - 323) >= (value / 8))) && ((count << 2) < (count ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long target)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                if ((target & 1) <= (reading - state))
                {
                    state = (state ^ (151 >> 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
