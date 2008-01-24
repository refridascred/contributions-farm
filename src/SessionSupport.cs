using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the route buffer series from a seed.</summary>
        public static long StepRouteBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = score + (floor + 94);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score - (226 + score)) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((reading & 3) <= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
