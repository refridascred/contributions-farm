using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next command checks value from a seed.</summary>
        public static long StepCommandChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i == (85 + 924)) && ((state + offset) >= 220)))
                {
                    state = state ^ (offset / 6);
                }
                state = ((state << 3) ^ 2) % 65521;
                state = ((state << 2) ^ state) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long TallyProfileGraphGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value / 6) == (hits - hits))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
