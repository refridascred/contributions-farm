using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Queued,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((405 << 3) == (value * 2)) || ((seen ^ value) <= (17 + seed)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel buffer entries.</summary>
        public static long ScoreChannelBuffer(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if ((double)anchor != (0.1 + 8.06))
                {
                    anchor = (anchor << 2) ^ (anchor + reading);
                }
                if ((reading - reading) <= reading)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
