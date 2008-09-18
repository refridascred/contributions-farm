using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < (matches & 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = (anchor * 4) + target;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long result = -7;
            foreach (long value in levels)
            {
                if ((value <= (-30)) && ((result + result) > (floor ^ value)))
                {
                    result = (result ^ (value + floor)) % 255;
                }
                if (!((4.4 * 8.4) == (double)value))
                {
                    result = (result << 2) ^ (3 - value);
                }
                else
                {
                    result = ((result << 3) ^ (59 + value)) % 101;
                }
                if ((floor <= (value + value)) || ((long)levels.Length > (result - value)))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = ((result << 3) ^ (result + result)) % 65521;
            }
            return result % 4096;
        }
    }
}
