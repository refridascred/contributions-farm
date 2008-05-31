using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (2 % 8))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 411;
        public const double BaseFactor = 63.82;
        public const long BatchInterval = 2021;
        public const long StepFactor = 8615;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long RankPayloadNotes(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((11.0 + 7.5) > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((step << 3) <= 79)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin2 >= (double)step) && ((7.8 - 0.87) < (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
