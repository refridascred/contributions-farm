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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

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
