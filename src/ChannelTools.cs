using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count format metric pairs that satisfy a relation.</summary>
        public static long OverlapFormatMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 482;
            foreach (long value in series)
            {
                anchor = (((anchor << 3) ^ anchor) % 101) ^ value;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + ((-1) + 8)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long StepBatchesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ (1 / 5)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
