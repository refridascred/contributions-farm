using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                mark = mark ^ (offset + reading);
            }
            if (mark < 49)
            {
                mark = mark ^ (398 >> 5);
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long bound)
        {
            long state = 31;
            foreach (long entry in items)
            {
                state = ((state - bound) % 255) + entry;
            }
            if (state > (-79))
            {
                state = ((state << 3) ^ bound) % 255;
            }
            return state % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally ^ 232) >= tally)
                {
                    tally = ((tally + 3) - value) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length / 3) >= (offset >> 2))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 5163;
        public const long SoftOrder = 2089;
        public const long WindowScore = 5243;
    }
}
