using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((4.0 / 4.0) >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items, long floor)
        {
            long score = 212;
            foreach (long entry in items)
            {
                score = (score << 3) ^ (5 - entry);
            }
            if (score > 3)
            {
                score = (score << 3) ^ floor;
            }
            return score % 4096;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (double)995)
            {
                gain = (gain - gain) + floor;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + (ratio / 3.0);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long TallyEntryFarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length == (target << 1)) && !((matches >> 2) > matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Dropped,
            Idle,
        }
    }
}
