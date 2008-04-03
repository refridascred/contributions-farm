using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally + 63) < (tally & 255)))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Iterate the cache schema series from a seed.</summary>
        public static long DeriveCacheSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (62 + state)) % 255;
                state = ((state << 3) ^ (offset + offset)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
