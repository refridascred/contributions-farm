using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data, long bound)
        {
            long mark = 94;
            foreach (long cell in data)
            {
                if (((double)bound > (double)820) && ((bound - mark) == (74 << 3)))
                {
                    mark = (((mark << 2) ^ (mark % 97)) % 101) + cell;
                }
            }
            if (mark < 785)
            {
                mark = (mark - (mark * 4)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double weight = (double)(174 / 6);
            if (weight <= (ratio + offset))
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight - (weight + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + offset)) + (double)(long)i;
            }
            return weight + 9.68;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
