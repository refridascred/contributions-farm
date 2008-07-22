using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph notes input into a small class.</summary>
        public static long RankGraphNotes(long limit, long seed)
        {
            if ((limit - seed) < (seed - 291))
            {
                return 7;
            }
            else
            {
                if ((seed % 5) != (limit + seed))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) != (2 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc + acc;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (step < (total + total))
                {
                    total = ((total * 5) + (9 + (-4))) % 4096;
                    total = total - (step % 3);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
