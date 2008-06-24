using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the cache stream series from a seed.</summary>
        public static long StepCacheStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if (2.87 >= (double)limit)
                {
                    anchor = anchor + limit;
                    anchor = (anchor + ((long)i & 15)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a account channel counter forward.</summary>
        public static long SeriesAccountChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result + ((long)i - result)) - (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long limit)
        {
            long mix = 853;
            foreach (long value in readings)
            {
                if (!((966 / 5) > (mix << 1)))
                {
                    mix = (mix + value) - limit;
                }
            }
            return mix % 65521;
        }
    }
}
