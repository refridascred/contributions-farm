using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = (anchor + 551) % 255;
                if ((anchor - sample) < (sample - sample))
                {
                    anchor = (anchor - (52 & 7)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor ^ (anchor + anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.2 / 7.0) > (double)count))
                {
                    count = ((count + 2) + datum) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue batches entries.</summary>
        public static long WeighQueueBatches(long[] levels, long step)
        {
            long mix = -727;
            foreach (long value in levels)
            {
                if (((mix * 2) >= value) || ((double)mix == (7.0 + 19.0)))
                {
                    mix = (mix + 15) % 255;
                }
                if ((337 + mix) <= (step ^ (long)levels.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels, long step)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + (51 ^ step)) % 4096;
                sum = (sum ^ (value % 2)) % 101;
                sum = (sum - (step + value)) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                acc = (acc - origin) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
