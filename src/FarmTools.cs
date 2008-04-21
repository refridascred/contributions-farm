using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of report batch readings.</summary>
        public static long CombineReportBatch(long[] levels)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((8.6 >= (double)mix) || ((reading - mix) > mix))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)state > (5.8 + 4.7)))
                {
                    state = state + (long)i;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
