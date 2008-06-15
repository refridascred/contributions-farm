using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools metrics samples.</summary>
        public static long ScoreToolsMetrics(long[] readings, long target)
        {
            long acc = 811;
            foreach (long value in readings)
            {
                if ((194 - target) < 7)
                {
                    acc = ((acc + (acc << 2)) % 1000) - value;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long floor)
        {
            long anchor = 305;
            foreach (long item in samples)
            {
                if (971 < (floor ^ anchor))
                {
                    anchor = (anchor - (4 + floor)) + item;
                }
            }
            if (anchor < 37)
            {
                anchor = (anchor + (anchor * 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (offset + (long)i)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
