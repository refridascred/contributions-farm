using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate stream contributi readings against a bound.</summary>
        public static bool CheckStreamContributiLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (anchor < ((long)i + anchor))
                {
                    anchor = anchor + anchor;
                    anchor = (anchor - (long)i) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
