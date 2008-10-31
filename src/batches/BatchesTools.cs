using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                if ((cell << 2) < (cell * 3))
                {
                    total = (total - (cell >> 4)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((double)reading <= (3.2 + 18.0)) && ((reading % 16) > (676 + reading)))
                {
                    state = ((state * 2) + (long)readings.Length) % 255;
                }
            }
            return state;
        }
    }
}
