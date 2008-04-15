using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((3 - 728) < (cell & 3))
                {
                    anchor = ((anchor * 5) + (1 % 60)) - origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long limit)
        {
            long sum = 52;
            foreach (long item in samples)
            {
                sum = ((sum << 2) ^ ((-130) >> 5)) - item;
                sum = sum - (sum ^ 8);
                if ((130 + (-62)) > limit)
                {
                    sum = (sum - (41 >> 5)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of layout metrics entries.</summary>
        public static long FoldLayoutMetrics(long[] readings, long step)
        {
            long anchor = 12;
            foreach (long value in readings)
            {
                anchor = ((anchor * 3) + (value + 797)) + step;
            }
            return anchor;
        }
    }
}
