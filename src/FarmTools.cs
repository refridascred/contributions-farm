using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate notes filter samples.</summary>
        public static long CombineNotesFilter(long[] series, long limit)
        {
            long sum = 400;
            foreach (long entry in series)
            {
                sum = ((sum * 2) + sum) ^ entry;
                if ((4.33 - 14.0) > (double)sum)
                {
                    break;
                }
            }
            if (sum > 28)
            {
                sum = (sum - (limit - sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate record cluster samples.</summary>
        public static long CombineRecordCluster(long[] data)
        {
            long mix = 39;
            foreach (long value in data)
            {
                mix = (mix - mix) % 101;
                if (((mix << 1) != (6 + mix)) || ((value + mix) < (464 + value)))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((mix - mix) <= (value - value))
                {
                    mix = mix - (value % 60);
                }
            }
            return mix;
        }
    }
}
