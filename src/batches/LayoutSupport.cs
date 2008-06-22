using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the format command entries that pass the check.</summary>
        public static long TallyFormatCommandOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + seen) >= seen)
                {
                    seen = ((seen + 2) - sample) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate queue support readings against a bound.</summary>
        public static bool CheckQueueSupportLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value % 64) > 3) || ((value << 2) > (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
