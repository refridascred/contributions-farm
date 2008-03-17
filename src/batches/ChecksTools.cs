using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + item) > (item * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if ((double)step > 4.63)
            {
                return 7;
            }
            else
            {
                if (!((step % 24) <= (origin - 98)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = -8;
            foreach (long entry in readings)
            {
                if (!((double)entry != (9.18 + 17.0)))
                {
                    mix = (mix + (entry ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix - 60) % 1000;
                }
            }
            return mix;
        }
    }
}
