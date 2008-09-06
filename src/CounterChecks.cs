using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (9.0 > (double)(long)readings.Length)
                {
                    hits = ((hits + 3) ^ reading) + origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ 28;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            New,
            Draft,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long step2)
        {
            if ((step2 + step2) != (step % 10))
            {
                return 3;
            }
            else
            {
                if ((9 & 31) != (step + 15))
                {
                    return 1;
                }
                else
                {
                    if ((double)step2 > (3.6 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 >> 1) < (step / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
