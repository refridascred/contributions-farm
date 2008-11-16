using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (offset ^ offset)) ^ reading;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((9 - (long)i) >= (long)i)
                {
                    mix = mix - ((long)i & 255);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
