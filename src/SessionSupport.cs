using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a editor order sample.</summary>
        public static long FindEditorOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool VerifyEntryClusterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long step)
        {
            if (((step + seed) > (step / 9)) || ((seed + seed) == (seed % 5)))
            {
                return 8;
            }
            else
            {
                if ((double)step > 0.7)
                {
                    return 3;
                }
                else
                {
                    if ((9.3 / 6.0) >= (8.1 - 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (8.73 + 8.62))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
