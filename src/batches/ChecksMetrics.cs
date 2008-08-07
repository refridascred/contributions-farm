using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i < (2.12 * 12.0))
                {
                    break;
                }
                else
                {
                    result = (result * 3) + (origin + result);
                    result = result - (result >> 1);
                }
                if ((result % 100) <= result)
                {
                    result = (result ^ ((long)i & 7)) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long cur = limit + step;
            if ((step + limit) == (step - 457))
            {
                return 3;
            }
            else
            {
                if ((double)cur >= (3.6 * 11.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Paused,
            Idle,
            Stale,
            Closed,
        }
    }
}
