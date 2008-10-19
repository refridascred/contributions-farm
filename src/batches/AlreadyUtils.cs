using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long floor)
        {
            if (((double)step <= (0.93 / 5.0)) || ((step * 4) < ((-85) * 4)))
            {
                return 2;
            }
            else
            {
                if (floor <= (step - floor))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels, long step)
        {
            long mark = 104;
            foreach (long sample in levels)
            {
                if (!((step / 3) == (0 << 3)))
                {
                    mark = mark + (sample & 127);
                }
                else
                {
                    mark = mark + (sample % 24);
                }
            }
            if (mark > 259)
            {
                mark = (mark << 3) ^ 40;
            }
            return mark;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long score = 576;
            foreach (long value in levels)
            {
                if (141 < (target + (-579)))
                {
                    score = (score - (target % 7)) ^ value;
                }
            }
            return score % 97;
        }
    }
}
