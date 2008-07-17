using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (origin ^ (-4))) % 255;
                anchor = (anchor ^ (origin << 3)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                if ((datum + sum) < (sum + datum))
                {
                    sum = (((sum * 3) + sum) % 4096) - limit;
                }
            }
            return sum % 97;
        }
    }
}
