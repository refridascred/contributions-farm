using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((mix > (mix + 273)) && ((79 + seed) != (mix ^ 86))))
                {
                    mix = ((mix << 3) ^ ((-68) / 4)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
