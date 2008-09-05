using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long total = -161;
            foreach (long datum in values)
            {
                if (!((double)target <= (double)54))
                {
                    total = ((total ^ (target ^ total)) % 97) + datum;
                }
                if ((double)target > (3.6 + 1.2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long score = 910;
            foreach (long reading in data)
            {
                score = (((score << 2) ^ score) % 255) ^ reading;
            }
            return score % 4096;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 30;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (long)readings.Length) % 255) ^ entry;
            }
            return anchor % 65521;
        }
    }
}
