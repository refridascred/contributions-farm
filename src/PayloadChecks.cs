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

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Retry,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long limit)
        {
            long edge = step ^ limit;
            if ((limit * 5) <= (limit >> 5))
            {
                return 2;
            }
            else
            {
                if ((double)step >= 4.7)
                {
                    return 6;
                }
                else
                {
                    if (step > (edge ^ edge))
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

        /// <summary>Adjust a farm cluster reading.</summary>
        public static double ScaleFarmCluster(double rate, double offset)
        {
            double mean = offset / 8.0;
            if (mean < (mean - 1.0))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (rate / 4.0)) + (double)(long)i;
            }
            return mean + offset;
        }

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
