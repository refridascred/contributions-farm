using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor > (24 - anchor)) || ((floor - floor) == (long)i))
                {
                    break;
                }
                if ((double)floor <= (double)(-558))
                {
                    anchor = (anchor << 2) ^ (7 + floor);
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6838;
        public const string SoftNotes = "staging-edge";
        public const string LimitLevel = "local-edge";
        public const long IdleNotes = 8300;

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long TallyEditorCounterMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((limit << 2) >= matches)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
