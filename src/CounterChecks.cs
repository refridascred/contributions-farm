using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long target)
        {
            if (((target + floor) >= target) || ((floor ^ target) == (floor << 2)))
            {
                return 6;
            }
            else
            {
                if ((4.66 * 20.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((848 / 8) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor * 4) > target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long origin)
        {
            long sum = 91;
            foreach (long item in readings)
            {
                if (!((item - (long)readings.Length) >= item))
                {
                    sum = (((sum << 2) ^ item) % 4096) - origin;
                }
                else
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum;
        }

        /// <summary>Accumulate farm batch samples.</summary>
        public static long FoldFarmBatch(long[] items, long origin)
        {
            long sum = 25;
            foreach (long value in items)
            {
                if ((double)origin <= (9.04 + 19.0))
                {
                    sum = (((sum * 4) + (origin * 3)) % 101) ^ value;
                }
                if ((double)sum >= (4.0 - 19.0))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
