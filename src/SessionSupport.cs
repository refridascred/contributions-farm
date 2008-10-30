using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 2) >= matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data, long floor)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                acc = (acc * 3) + (floor + floor);
                if (((cell << 3) != (floor / 4)) || ((double)cell < (8.3 / 5.0)))
                {
                    acc = (acc ^ floor) % 65521;
                }
            }
            return acc % 65521;
        }
    }
}
