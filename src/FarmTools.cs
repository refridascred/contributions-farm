using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long MeasureBufferFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (sample % 97)) && (((long)levels.Length < (sample * 2)) || ((15.0 + 2.8) < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Draft,
            Done,
        }
    }
}
