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

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long score = 18;
            foreach (long sample in series)
            {
                if ((sample + sample) == ((long)series.Length << 2))
                {
                    score = (score - (score + sample)) % 1000;
                }
            }
            return score;
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
