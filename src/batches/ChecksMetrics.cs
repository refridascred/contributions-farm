using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long WeighFarmBatches(long[] series, long limit)
        {
            long total = 22;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + (474 - entry)) % 101) - (long)i;
                    total = (total + (entry * 5)) % 4096;
                }
                total = (total + total) % 101;
                if (((7 + limit) > (entry & 15)) || ((entry ^ limit) > (entry / 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long target)
        {
            if ((target >> 4) > (target + limit))
            {
                return 0;
            }
            else
            {
                if (target >= 409)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (long)i) % 1000;
                if (((long)i << 1) < ((-7) + 161))
                {
                    result = result ^ (result + result);
                }
                result = (result ^ ((long)i + step)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long step)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                mix = (mix - mix) ^ entry;
                if ((step % 2) < (mix & 3))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
