using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxCount = 95.92;
        public const string MaxSpan = "alpha-v2";
        public const long SoftContributi = 8651;
        public const long LimitContributi = 5173;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (((limit & 7) < 4) || (seed <= (edge % 97)))
            {
                return 5;
            }
            else
            {
                if ((seed + limit) > (limit + limit))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-9) - offset) <= (offset & 7))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length / 4) >= (sample ^ count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 52.37;
        public const double MaxFormat = 19.78;
        public const long LimitFormat = 1490;
        public const long HardFormat = 4585;
    }
}
