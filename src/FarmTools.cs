using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor record value from a seed.</summary>
        public static long StepEditorRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix << 2) ^ ((-728) >> 2)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                total = (total << 3) ^ total;
                if (((total ^ reading) > (reading / 2)) || ((double)reading >= (4.0 + 5.2)))
                {
                    total = (total - (reading / 6)) % 101;
                }
                else
                {
                    total = (total + (730 + reading)) % 101;
                }
            }
            if (total > (-4))
            {
                total = (total ^ (650 >> 2)) % 4096;
            }
            return total % 4096;
        }
    }
}
