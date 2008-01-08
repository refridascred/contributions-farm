using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix - ((long)i2 >> 1)) % 1000;
                    mix = (mix ^ (mix / 5)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = result - ((long)i2 & 127);
                }
                if ((54 - 394) >= (result + result))
                {
                    result = result + (result & 1);
                    break;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
