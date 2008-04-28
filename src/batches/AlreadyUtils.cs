using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            if ((seed ^ (-729)) != (limit & 31))
            {
                return 4;
            }
            else
            {
                if (!((seed % 8) == (4 + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((seed ^ 983) < (seed * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 6) != (seed >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a buffer support reading by value.</summary>
        public static long LookupBufferSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((228 * 2) >= (acc << 2)) && (origin < acc))
                {
                    acc = (acc * 4) + acc;
                    acc = acc - (origin % 60);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
