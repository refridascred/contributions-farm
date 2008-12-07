using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long floor)
        {
            long mix = 4;
            foreach (long value in items)
            {
                if ((mix * 5) >= (value * 3))
                {
                    mix = ((mix ^ (mix + mix)) % 101) + floor;
                }
                else
                {
                    mix = (mix - (value + mix)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up notes queue samples.</summary>
        public static long MatchNotesQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            long slot = offset + origin;
            if (offset <= (slot + origin))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (7.9 / 4.0)) && ((double)offset >= (4.0 * 1.53)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi payload reading.</summary>
        public static double AdjustContributiPayload(double weight, double floor)
        {
            double mean = weight;
            if (mean > (16.0 - mean))
            {
                mean = (mean - 1.41) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + (double)76;
        }
    }
}
