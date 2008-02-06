using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                long cur = (offset + offset) / 8;
                long slot = (offset ^ score) ^ (cur * 4);
                if (score < (offset & 63))
                {
                    score = score + slot;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
