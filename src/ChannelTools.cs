using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches >= (4 - reading)) && ((reading - reading) != (matches << 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (offset - offset))
            {
                rate = rate - (ratio / 2.0);
            }
            return rate + (rate / 4.0);
        }
    }
}
