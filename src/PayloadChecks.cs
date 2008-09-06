using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long acc = 132;
            foreach (long value in values)
            {
                if ((907 ^ acc) > (value * 5))
                {
                    acc = (acc + (value * 4)) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 4096;
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

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if ((total > (cell * 3)) && ((7 * 4) <= (cell - cell)))
                {
                    total = ((total << 3) ^ (2 + 94)) % 1000;
                }
                else
                {
                    total = total + 4;
                }
            }
            return total;
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
