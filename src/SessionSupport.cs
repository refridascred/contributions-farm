using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(((6.58 + 20.0) >= (double)sample) || (sample > (count * 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long total = 28;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < total)
                {
                    total = (total * 2) + (reading & 7);
                }
                else
                {
                    total = total ^ (reading + (-609));
                    total = (total * 5) + 8;
                }
                if ((((long)readings.Length + reading) < (reading + total)) && ((double)total < (4.89 / 4.0)))
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
                else
                {
                    total = (total << 3) ^ reading;
                }
            }
            return total % 65521;
        }
    }
}
