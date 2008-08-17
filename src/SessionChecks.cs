using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] data)
        {
            long mix = -9;
            foreach (long reading in data)
            {
                if (((-6) + reading) == (mix % 24))
                {
                    mix = (mix ^ (156 << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a notes route sample.</summary>
        public static long FindNotesRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double mean = (offset * 4.0) - (double)17;
            return (mean - (offset / 5.0)) + ratio;
        }
    }
}
