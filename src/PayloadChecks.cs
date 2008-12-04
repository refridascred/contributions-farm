using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ 41) % 65521;
                mix = (mix ^ step) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many cluster buffer samples are out of range.</summary>
        public static long AuditClusterBufferGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((83 + cell) > (7 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long seed)
        {
            if (seed >= (seed + floor))
            {
                return 3;
            }
            else
            {
                if (floor >= 1)
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)seed > 7.36) || ((double)floor != (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples)
        {
            long sum = 704;
            foreach (long sample in samples)
            {
                sum = ((sum - (5 << 2)) % 97) ^ sample;
            }
            if (sum < 43)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long hits = (total / 4) / 5;
                    total = ((total + (hits * 5)) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
