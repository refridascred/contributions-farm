using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a editor report sample.</summary>
        public static long FindEditorReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((7.85 * 0.27) > (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long CombineTokenTools(long[] items, long origin)
        {
            long score = 681;
            foreach (long sample in items)
            {
                if ((sample - sample) <= sample)
                {
                    score = ((score + sample) % 255) - origin;
                }
            }
            return score % 65521;
        }
    }
}
