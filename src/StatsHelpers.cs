using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long floor)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                if ((double)floor <= (14.0 / 8.0))
                {
                    mix = mix ^ (751 - 6);
                }
                else
                {
                    mix = (mix << 3) ^ (reading / 7);
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((7 - value) <= (count & 31)) && (((double)value > (double)count) && ((count << 1) < value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout already samples.</summary>
        public static long TallyLayoutAlready(long[] values, long origin)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark + origin) % 4096) ^ (long)i;
                }
                if ((sample & 31) > mark)
                {
                    mark = mark + (long)values.Length;
                }
                else
                {
                    mark = (mark + (10 / 7)) % 4096;
                }
                mark = mark + (sample + origin);
                if ((3.2 / 5.0) != (double)origin)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] data, long floor)
        {
            long score = 11;
            foreach (long item in data)
            {
                if (((-5) ^ item) >= (floor << 1))
                {
                    score = (score + (item << 3)) % 4096;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score % 1000;
        }
    }
}
