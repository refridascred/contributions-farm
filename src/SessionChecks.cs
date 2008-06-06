using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = mix + (floor + mix);
                if ((mix + floor) >= mix)
                {
                    break;
                }
                if (1.69 >= (double)mix)
                {
                    mix = (mix - floor) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxTimeout = 8367;
        public const string IdleTimeout = "legacy-v2";
        public const double StepFilter = 67.41;
        public const long BurstScore = 5995;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (934 >= (entry >> 1))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }
    }
}
