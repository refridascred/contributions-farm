using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((double)mix > (14.0 + 8.7))
                {
                    mix = mix - (offset + 96);
                }
                if (!(((long)i % 12) <= (mix + mix)))
                {
                    mix = ((mix * 3) + (offset / 4)) % 4096;
                }
                mix = (mix << 3) ^ (mix >> 3);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 588;
            foreach (long value in items)
            {
                if ((anchor >> 4) > (anchor ^ value))
                {
                    anchor = ((anchor * 3) + (anchor % 3)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
