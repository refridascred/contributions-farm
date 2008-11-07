using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long CountClusterGithubfarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= 810)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a order profile pair into a bucket.</summary>
        public static long BucketOrderProfile(long step, long limit)
        {
            long gap = step - limit;
            if ((limit >> 2) > (25 + gap))
            {
                return 5;
            }
            else
            {
                if (gap > (gap << 1))
                {
                    return 0;
                }
                else
                {
                    if ((22 + step) < (limit << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix - (mix + seed)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.7 / 6.0) < (double)(long)i)
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score << 2) ^ (score + score)) % 97;
                }
                score = (score + score) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
