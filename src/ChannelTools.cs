using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc + 48)) % 4096;
                if ((sample / 5) != (target + target))
                {
                    acc = ((acc * 4) + (0 & 3)) % 65521;
                }
            }
            if (acc > 744)
            {
                acc = ((acc * 2) + (acc / 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (floor > entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
