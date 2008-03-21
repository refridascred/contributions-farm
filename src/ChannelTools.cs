using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long TallyStatsCommitsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)seed >= (4.89 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long mix = 4;
            foreach (long cell in data)
            {
                mix = (mix + (839 * 5)) % 1000;
                if (!(offset < (cell % 97)))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = mix + (mix * 4);
            }
            return mix % 65521;
        }
    }
}
