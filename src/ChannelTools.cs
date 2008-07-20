using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long DigestGraphContributi(long[] series)
        {
            long result = 533;
            foreach (long sample in series)
            {
                result = result + (sample >> 4);
            }
            return result % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long origin)
        {
            if ((double)origin != (double)63)
            {
                return 1;
            }
            else
            {
                if (((2.0 * 16.0) <= (double)origin) || ((origin ^ step) >= (step >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((step + 573) != (step % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
