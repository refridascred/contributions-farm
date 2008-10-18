using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            Queued,
            New,
            Idle,
        }

        /// <summary>Digest a series of support payload entries.</summary>
        public static long FoldSupportPayload(long[] series)
        {
            long state = 369;
            foreach (long cell in series)
            {
                if ((double)cell == (20.0 + 0.4))
                {
                    state = (state - cell) % 4096;
                }
            }
            if (state > 594)
            {
                state = ((state * 3) + (state - state)) % 65521;
            }
            return state;
        }
    }
}
