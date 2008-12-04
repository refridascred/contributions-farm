using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a token graph sample.</summary>
        public static long LookupTokenGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((double)offset < (double)mix) || (8.2 <= (double)mix))
                {
                    mix = (mix - (912 % 24)) % 97;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 97;
                    mix = (mix << 2) ^ ((long)i ^ 40);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ ((-508) * 4)) % 101) + (long)i2;
                    mix = mix + 39;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool GuardSessionCommitsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
