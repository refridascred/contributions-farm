using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                mix = (mix + (entry << 3)) + offset;
            }
            return mix;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double rate = (double)(59 % 16);
            return ((rate + (double)151) + ratio) + floor;
        }
    }
}
