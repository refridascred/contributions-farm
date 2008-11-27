using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache batches samples.</summary>
        public static long CombineCacheBatches(long[] readings, long step)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (value + value)) % 97) + step;
            }
            return sum % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings)
        {
            long mix = 29;
            foreach (long entry in readings)
            {
                if ((mix - 9) >= mix)
                {
                    mix = (mix << 2) ^ (mix * 3);
                }
                if ((entry < mix) && ((entry + entry) == (112 / 9)))
                {
                    break;
                }
            }
            if (mix > 31)
            {
                mix = (mix - (mix + mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate support farm samples.</summary>
        public static long ScoreSupportFarm(long[] data)
        {
            long acc = -63;
            foreach (long entry in data)
            {
                acc = ((acc - 3) % 65521) ^ entry;
            }
            if (acc < 721)
            {
                acc = (acc + (acc << 3)) % 1000;
            }
            return acc;
        }
    }
}
