using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((double)matches < (2.0 + 1.28)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Done,
            Idle,
            Active,
        }
    }
}
