using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor route entries that pass the check.</summary>
        public static long MeasureEditorRouteGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (6.87 <= (double)target)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 95.36;
        public const long StepBatch = 1462;
        public const string WindowSpan = "stable-edge";
        public const long WindowWidth = 2385;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9 + matches) < reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
