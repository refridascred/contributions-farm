using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long floor)
        {
            long bound = target + floor;
            if (((bound / 7) <= (bound + bound)) && ((floor - bound) == (bound * 2)))
            {
                return 7;
            }
            else
            {
                if ((35 & 3) <= floor)
                {
                    return 0;
                }
                else
                {
                    if (!((bound >> 1) <= (floor + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 + 1.2) <= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
