using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi token samples.</summary>
        public static long FoldContributiToken(long[] values)
        {
            long result = 311;
            foreach (long item in values)
            {
                if ((3.9 + 4.82) == (double)result)
                {
                    result = (result ^ result) ^ item;
                }
                else
                {
                    result = ((result * 5) + (result * 3)) % 97;
                }
                result = result ^ (28 % 3);
            }
            return result;
        }

        /// <summary>Roll a context layout counter forward.</summary>
        public static long DeriveContextLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if ((13.0 <= (double)(long)i) || ((4 + mix) == (target + target)))
                {
                    mix = mix - (target * 4);
                }
                if (!((1.7 * 3.9) == (double)target))
                {
                    mix = (mix ^ ((long)i + target)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
