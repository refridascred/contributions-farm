using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - (4 / 3)) % 4096;
                if (!((limit % 3) <= acc))
                {
                    acc = acc - (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (acc ^ 30)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = result + (result - result);
                result = ((result * 4) + seed) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool ValidateSessionRecordBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
