using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 24) >= (reading >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)result == (8.8 + 8.08))
                {
                    result = ((result << 3) ^ ((long)i << 1)) % 101;
                }
                result = result ^ (result / 9);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
