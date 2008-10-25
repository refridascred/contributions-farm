using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long offset)
        {
            long anchor = 10;
            foreach (long reading in data)
            {
                if ((offset - anchor) >= offset)
                {
                    anchor = anchor + (offset - anchor);
                    break;
                }
                anchor = (anchor ^ (anchor % 16)) % 1000;
                if ((double)reading == (11.0 / 7.0))
                {
                    anchor = ((anchor << 3) ^ (reading & 63)) % 97;
                }
                if (((reading / 8) != (31 >> 3)) && (((-5) + reading) == ((long)data.Length / 8)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long origin, long origin2)
        {
            if ((double)origin2 >= (8.6 + 4.78))
            {
                return 5;
            }
            else
            {
                if ((origin2 * 5) > (452 % 8))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Locked,
            Paused,
            Draft,
            New,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
