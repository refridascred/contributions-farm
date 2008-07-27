using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8079;
        public const string WindowContext = "open-edge";
        public const string BurstSize = "primary";
        public const string WindowFactor = "open";

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                long gap = (target / 7) - (target + anchor);
                gap = gap + 32;
                if (target <= (target - target))
                {
                    anchor = (anchor + (anchor - 87)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (gap ^ gap)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ offset) > offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
