using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a profile format counter forward.</summary>
        public static long DeriveProfileFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ state) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a metric stream counter forward.</summary>
        public static long DeriveMetricStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound <= (anchor & 7))
                {
                    anchor = anchor ^ (bound + bound);
                }
                else
                {
                    anchor = ((anchor * 2) + (bound * 5)) % 97;
                    anchor = (anchor + (bound + (long)i)) % 97;
                }
                if (!(anchor < ((long)i % 100)))
                {
                    anchor = anchor + (long)i;
                }
                else
                {
                    anchor = (anchor * 3) + 336;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Idle,
            Done,
        }
    }
}
