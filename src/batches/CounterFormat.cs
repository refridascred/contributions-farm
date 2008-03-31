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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) <= cell)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
