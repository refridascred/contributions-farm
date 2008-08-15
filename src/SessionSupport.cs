using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long seed)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((cell + score) >= (score + 957))
                {
                    score = (score - (seed + cell)) % 1000;
                }
                else
                {
                    score = score + (cell * 5);
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                if ((double)item != (1.0 - 7.8))
                {
                    mark = (mark - (0 - 925)) % 97;
                    continue;
                }
                if ((item * 5) < (123 / 8))
                {
                    mark = ((mark * 5) + (item - mark)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (item + 15)) % 1000;
                }
            }
            if (mark > (-781))
            {
                mark = (mark - (mark / 9)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
