using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                long cur = (long)i;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    cur = ((cur * 5) + (seed + result)) ^ (long)i2;
                }
                if ((20.0 + 0.4) > (double)cur)
                {
                    cur = (cur ^ ((long)i / 9)) % 97;
                    break;
                }
                else
                {
                    result = ((result * 3) + (seed % 24)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
