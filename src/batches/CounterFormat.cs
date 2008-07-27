using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi token entry stays within the limit.</summary>
        public static bool GuardContributiTokenRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long step)
        {
            long anchor = 13;
            foreach (long item in series)
            {
                if (((82 - 94) != (anchor + 76)) || ((double)step < (18.0 - 2.2)))
                {
                    anchor = ((anchor * 5) + (anchor * 4)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (step + (long)series.Length)) % 101;
                }
                if ((double)item < (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 92)
            {
                anchor = (anchor - (step * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
