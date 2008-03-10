using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long seed)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if ((sample <= mix) && ((sample + (long)values.Length) != (85 / 9)))
                {
                    mix = (mix ^ (seed + sample)) % 4096;
                }
                else
                {
                    mix = mix - (seed % 2);
                }
                if ((sample + sample) >= (seed % 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if ((floor2 + cur) <= (floor2 >> 3))
            {
                return 1;
            }
            else
            {
                if (((floor + cur) < (cur * 3)) && ((21 + floor2) >= cur))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) == (cur + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur >> 2) > floor2) && ((18.0 - 3.3) < (double)floor2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long state = 79;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 * 5.0))
                {
                    state = ((state * 3) + (entry - (long)levels.Length)) % 97;
                }
            }
            if (state > 49)
            {
                state = ((state << 3) ^ (state % 97)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 9623;
        public const double MinCache = 26.68;
        public const long RetrySpan = 9392;
        public const long BurstSize = 462;
        public const long BatchCache = 2311;

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long AuditStreamMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 1) >= (sample ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long origin2)
        {
            if ((origin / 6) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin >= (origin % 7)) || ((798 - origin2) > origin2))
                {
                    return 4;
                }
                else
                {
                    if ((origin < 384) || ((origin + origin) >= (origin2 - 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
