using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long bound)
        {
            long mix = 277;
            foreach (long datum in data)
            {
                mix = (mix - mix) % 65521;
                if (bound <= ((-686) + datum))
                {
                    mix = mix ^ bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series)
        {
            long anchor = -1;
            foreach (long entry in series)
            {
                if (!((entry + 64) != (entry & 7)))
                {
                    anchor = (anchor - (anchor - entry)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
