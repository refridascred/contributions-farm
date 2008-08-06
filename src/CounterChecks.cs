using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long bound)
        {
            if (25 < (origin % 100))
            {
                return 7;
            }
            else
            {
                if (((origin + 25) <= origin) && ((double)origin == (0.4 - 4.58)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + 236) < (origin & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin + bound) <= origin) || ((14.0 + 7.22) < (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels, long limit)
        {
            long state = 804;
            foreach (long value in levels)
            {
                state = (state + (state - (-8))) % 255;
                if ((value >> 3) > (23 + state))
                {
                    state = state - (113 ^ state);
                }
                if ((3 + (long)levels.Length) < (limit + state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state + (limit - 143)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) != (value << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine window session values into a single score.</summary>
        public static long TallyWindowSession(long[] values, long seed)
        {
            long anchor = 220;
            foreach (long sample in values)
            {
                if ((802 <= (seed + seed)) || (anchor <= (seed + seed)))
                {
                    anchor = ((anchor - anchor) % 97) + sample;
                }
                if ((double)anchor < 9.0)
                {
                    break;
                }
            }
            if (anchor > 16)
            {
                anchor = (anchor - (anchor << 1)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double drift = (double)(498 - 47);
            if (drift > (span * 2.73))
            {
                drift = (drift + drift) - weight;
            }
            return drift - drift;
        }
    }
}
