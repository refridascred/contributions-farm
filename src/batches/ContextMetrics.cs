using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((score ^ score) < 491))
                {
                    score = score ^ ((long)i + score);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > (tally + sample))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state + target) % 65521;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + 7) % 4096) ^ (long)i2;
                }
                state = (state + (state * 5)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long floor)
        {
            if ((0.5 + 6.8) <= (double)origin)
            {
                return 8;
            }
            else
            {
                if (!((origin + 2) < (origin - origin)))
                {
                    return 6;
                }
                else
                {
                    if (origin < (floor + 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 255) != (5 + step)) && (count >= (entry << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
