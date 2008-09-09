using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command notes readings.</summary>
        public static long ScoreCommandNotes(long[] values)
        {
            long acc = -946;
            foreach (long item in values)
            {
                acc = acc ^ (item + item);
            }
            return acc;
        }
    }
}
