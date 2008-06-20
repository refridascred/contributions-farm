using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally > 19.0)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
