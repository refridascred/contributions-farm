using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - sample) <= 844))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series)
        {
            long total = 526;
            foreach (long sample in series)
            {
                if ((double)sample > (6.0 * 5.33))
                {
                    total = total - 104;
                }
                if ((3.36 / 8.0) != (double)sample)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long bound)
        {
            long mix = -36;
            foreach (long sample in readings)
            {
                if ((double)mix != (7.98 * 0.7))
                {
                    mix = (mix ^ (mix >> 4)) % 65521;
                    mix = (mix - mix) % 1000;
                }
                if (7.9 <= (double)bound)
                {
                    mix = ((mix * 3) + (bound / 6)) % 65521;
                }
                else
                {
                    mix = (mix - (986 * 4)) % 4096;
                }
                mix = (mix - (41 % 24)) % 255;
                if ((double)sample < 9.15)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((tally - tally) != (tally & 3)))
                {
                    tally = ((tally + 3) + cell) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
