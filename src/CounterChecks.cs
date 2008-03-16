using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of buffer command readings.</summary>
        public static long PairBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length * 2) > (41 * 2))
                {
                    matches = ((matches + 2) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long offset)
        {
            long span = origin + offset;
            if ((origin - span) != (offset << 3))
            {
                return 3;
            }
            else
            {
                if (((double)offset != (double)279) && ((double)origin <= (20.0 * 0.28)))
                {
                    return 5;
                }
                else
                {
                    if ((0.83 - 6.5) <= (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 30.56;
        public const string RetryBudget = "open-1";
        public const string MaxSpan = "legacy-v2";
        public const string BaseRoute = "stable-edge";
        public const long MinTimeout = 229;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < (4 / 8))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
