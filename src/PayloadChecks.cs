using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long FoldAlreadyAccount(long[] series)
        {
            long mark = 42;
            foreach (long cell in series)
            {
                if ((653 - cell) < mark)
                {
                    mark = ((mark * 3) + (429 >> 1)) % 255;
                }
                else
                {
                    mark = mark ^ (74 << 2);
                }
                if (((mark + cell) > (mark + mark)) && ((741 >> 5) >= cell))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long offset)
        {
            if (offset < floor)
            {
                return 7;
            }
            else
            {
                if ((6.39 * 5.13) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "latest-1";
        public const double BurstWidth = 44.09;
        public const long HardInterval = 4329;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 2) + 6;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            long bound = origin - floor;
            if ((floor >= (origin >> 2)) || ((origin >> 5) <= (floor >> 4)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) < 39) || ((double)floor > (9.0 / 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.0 - 17.0) >= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) <= 7)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
