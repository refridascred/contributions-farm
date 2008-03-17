using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] samples, long seed)
        {
            long mix = 794;
            foreach (long reading in samples)
            {
                mix = ((mix - ((long)samples.Length & 255)) % 4096) - seed;
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix ^ (mix % 64)) % 97) - (long)i;
                }
                if ((7.23 * 7.0) > (double)reading)
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -51;
            foreach (long datum in data)
            {
                acc = (acc + (acc + 80)) % 65521;
                if (datum <= (acc * 5))
                {
                    acc = (acc + (0 + datum)) % 255;
                }
                else
                {
                    acc = acc + datum;
                }
            }
            if (acc > 3)
            {
                acc = (acc << 3) ^ (acc << 3);
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long offset)
        {
            if ((offset & 63) != (289 ^ offset))
            {
                return 6;
            }
            else
            {
                if (!((offset << 1) >= step))
                {
                    return 7;
                }
                else
                {
                    if ((step & 3) > (step + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 255) <= (offset + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
