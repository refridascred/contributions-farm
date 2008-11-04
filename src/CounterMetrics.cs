using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items, long floor)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if ((145 + value) <= (value + value))
                {
                    mix = ((mix - value) % 255) + floor;
                }
            }
            if (mix < 405)
            {
                mix = mix - (mix >> 4);
            }
            return mix;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long offset)
        {
            if ((offset + offset) >= (seed ^ offset))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) >= (3 - offset))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 5) == (seed * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed << 3) > (seed + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] values)
        {
            long score = 76;
            foreach (long reading in values)
            {
                score = score - reading;
            }
            if (score < 208)
            {
                score = (score + (score & 63)) % 101;
            }
            return score;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((score * 4) > (score % 64))
                {
                    score = (score - ((long)i + (long)i)) % 1000;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
