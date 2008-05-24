using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long step)
        {
            long lane = target - step;
            if (step < (target ^ target))
            {
                return 2;
            }
            else
            {
                if ((lane - lane) < (step << 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many record githubfarm samples are out of range.</summary>
        public static long MeasureRecordGithubfarmMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (6.0 + 1.0)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count context token pairs that satisfy a relation.</summary>
        public static long PairContextTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if ((step + 346) <= (origin & 15))
            {
                return 8;
            }
            else
            {
                if (((step + 8) < (origin * 2)) || ((double)step == (2.0 * 2.6)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
