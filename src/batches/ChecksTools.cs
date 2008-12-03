using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= seed)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool VerifyNotesBufferLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (offset * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate / 3.0)) + (double)(long)i;
            }
            return mean + (rate + 9.0);
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(seen <= (seen % 10)))
                {
                    seen = ((seen + 1) ^ reading) + bound;
                }
            }
            return seen;
        }
    }
}
