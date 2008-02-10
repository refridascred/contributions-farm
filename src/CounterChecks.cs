using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 5876;
        public const double RetryCluster = 39.95;
        public const long DefaultCluster = 1155;

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long limit)
        {
            long cur = seed + limit;
            if ((seed >> 1) > limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit < 19.0)
                {
                    return 8;
                }
                else
                {
                    if (((20.0 * 19.0) >= (double)limit) && ((13.0 / 8.0) != (double)cur))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                if (((datum + datum) >= (75 * 3)) || ((7.9 - 4.82) >= (double)datum))
                {
                    mix = (mix << 3) ^ (datum >> 4);
                    break;
                }
                mix = (mix ^ mix) % 97;
                mix = (mix ^ (mix / 2)) % 97;
            }
            return mix;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double weight = bias;
            return (weight - bias) + floor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) > (83 - reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
