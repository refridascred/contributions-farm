using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "standard-1";
        public const double WindowReport = 75.89;
        public const long HardReport = 8920;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry >= (step / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((value ^ seen) > seen) && ((value / 6) <= (value << 1))) || ((value % 5) >= value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Done,
            Pending,
        }
    }
}
