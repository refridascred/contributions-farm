using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a stream report counter forward.</summary>
        public static long StepStreamReport(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                long bound = 0 & 127;
                long delta = (bound + bound) * 3;
                result = (result - ((-88) + delta)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                long offset2 = offset ^ (long)i;
                if (((state % 64) < offset2) && (((long)i * 4) != (state / 4)))
                {
                    state = state - state;
                    state = (state - (5 - 2)) % 1000;
                }
                state = (state + ((long)i * 4)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((seed + seed) <= 840)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
