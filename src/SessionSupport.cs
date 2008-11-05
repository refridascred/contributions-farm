using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 3) ^ (mix - (long)i);
                mix = ((mix * 5) + ((long)i ^ (long)i)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long result = 943;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result << 3) ^ result) + (long)i;
                }
                result = (result + (long)readings.Length) % 65521;
                if ((double)floor > (8.0 + 6.82))
                {
                    result = result - (floor / 7);
                }
                else
                {
                    result = (result + (sample + floor)) % 4096;
                }
            }
            return result;
        }
    }
}
