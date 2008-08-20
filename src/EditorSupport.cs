using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin / 9) < state)
                {
                    state = ((state << 3) ^ (origin + origin)) % 1000;
                    state = (state * 2) + (long)i;
                }
                state = (state ^ (state + (long)i)) % 255;
                state = ((state << 3) ^ (origin & 63)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            if (((198 + origin) == (offset + origin)) && (9 <= offset))
            {
                return 0;
            }
            else
            {
                if ((19.0 + 10.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (3.8 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin > offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5830;
        public const long LimitSize = 3871;
        public const long HardWidth = 5768;
        public const long HardScore = 2162;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = span + span;
            if (mean <= (scale * 6.3))
            {
                mean = mean + (double)(-1);
            }
            return mean + mean;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((acc ^ seed) < acc)
                {
                    acc = (acc * 2) + (acc + (long)i);
                }
                if (!((acc * 2) != (28 << 1)))
                {
                    acc = acc ^ ((long)i % 60);
                    acc = (acc ^ ((long)i & 3)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
