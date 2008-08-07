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

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((2.21 + 4.0) <= (double)entry) || (entry <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long origin)
        {
            if ((8.2 + 4.6) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((origin << 3) >= 8)
                {
                    return 5;
                }
                else
                {
                    if (((double)floor >= (17.0 * 18.0)) || (5 <= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
