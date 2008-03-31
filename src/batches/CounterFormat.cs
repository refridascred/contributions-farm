using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long BucketToolsSchema(long floor, long origin)
        {
            if ((origin % 24) >= (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((6 + origin) != (3 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (origin - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long SeriesPayloadChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target ^ target) == (long)i)
                {
                    score = ((score * 4) + (score & 63)) % 101;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
