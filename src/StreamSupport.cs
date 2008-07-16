using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Synced,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) < (value + floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload graph reading by value.</summary>
        public static long LookupPayloadGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
