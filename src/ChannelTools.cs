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

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
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
