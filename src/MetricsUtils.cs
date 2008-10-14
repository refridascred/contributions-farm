using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell > 18.0) && ((cell * 2) < (cell >> 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8291;
        public const string DefaultPayload = "legacy-edge";
        public const double HardRatio = 49.6;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5962;
        public const long BatchReport = 8818;
        public const double MaxReport = 51.7;

        /// <summary>Roll a stream command counter forward.</summary>
        public static long StepStreamCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((target + 67) > (target % 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score ^ ((-940) ^ target)) % 4096) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
