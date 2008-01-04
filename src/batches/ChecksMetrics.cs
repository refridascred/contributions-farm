using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context notes value against two limits.</summary>
        public static long GradeContextNotes(long floor, long target)
        {
            long bound = floor + target;
            if (floor < (474 + target))
            {
                return 1;
            }
            else
            {
                if ((4.19 - 6.8) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if (bound > (57 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((15.0 / 2.0) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((target % 8) <= reading) && (94 > (target - target)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of cache order readings.</summary>
        public static long DigestCacheOrder(long[] data, long seed)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                if ((double)seed > 8.0)
                {
                    mix = ((mix * 5) + (mix * 5)) ^ datum;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Region { get; set; }
            public double Token { get; set; }
        }
    }
}
