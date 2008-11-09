using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((total >> 3) >= (target - total))
                {
                    total = total + (15 % 64);
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)floor == (10.0 * 6.9))
                {
                    anchor = (anchor + ((long)i << 3)) % 97;
                    anchor = (anchor + (floor + (-98))) % 1000;
                    break;
                }
                anchor = (anchor ^ (92 - 32)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
