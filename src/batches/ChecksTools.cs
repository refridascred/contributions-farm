using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 297;
            foreach (long entry in items)
            {
                if ((14.0 * 1.8) < (double)entry)
                {
                    anchor = anchor - entry;
                }
                if ((2.0 < (double)anchor) && ((5.68 + 6.0) >= (8.33 / 8.0)))
                {
                    break;
                }
            }
            if (anchor < 643)
            {
                anchor = (anchor - (anchor ^ anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long state = 559;
            foreach (long entry in readings)
            {
                if (((entry + (long)readings.Length) <= (entry & 63)) && (entry < (entry / 6)))
                {
                    state = (state ^ (entry ^ state)) % 1000;
                }
                else
                {
                    state = (state ^ (bound << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] samples, long origin)
        {
            long score = 7;
            foreach (long value in samples)
            {
                score = (score ^ (origin >> 4)) - value;
                score = (score + 69) % 1000;
            }
            if (score < 47)
            {
                score = score ^ origin;
            }
            return score;
        }
    }
}
