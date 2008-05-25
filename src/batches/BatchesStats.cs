using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - cell) == (count / 5))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if (913 < (origin - (long)i))
                {
                    continue;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = mark - ((long)i3 ^ mark);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor - seed) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if ((seed <= (367 - 4)) && ((floor + floor) >= (5 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + seed) >= (52 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor - seed) > (seed / 5)) && (1.11 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((699 << 3) < (mix - mix))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ ((long)i + mix)) % 65521;
                }
                if (((long)i << 1) <= (75 + mix))
                {
                    mix = mix ^ ((long)i * 5);
                    mix = mix ^ (mix << 1);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
