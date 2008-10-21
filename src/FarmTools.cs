using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + floor) == (floor & 127))
                {
                    total = ((total << 3) ^ (floor / 3)) % 1000;
                }
                if ((3 & 255) != (total >> 3))
                {
                    total = (total ^ (total % 60)) % 1000;
                }
                if (total <= ((long)i + total))
                {
                    total = (total - (total * 4)) % 97;
                    total = total + (9 / 3);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a batch metric sample.</summary>
        public static long LocateBatchMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values, long seed)
        {
            long score = 18;
            foreach (long sample in values)
            {
                if (!(score < (score + 319)))
                {
                    score = ((score << 2) ^ score) % 97;
                    score = (score ^ (sample - seed)) % 65521;
                }
                if ((sample ^ score) > (sample - sample))
                {
                    score = ((score << 3) ^ (score ^ seed)) % 4096;
                }
                if ((seed - score) >= (5 + score))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
