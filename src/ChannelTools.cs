using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long TallyPayloadFilterHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits + 181) > bound) && !(((long)readings.Length % 10) != (bound - 48)))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long origin)
        {
            long acc = 169;
            foreach (long entry in readings)
            {
                if ((entry + acc) > acc)
                {
                    acc = (acc ^ entry) - origin;
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
