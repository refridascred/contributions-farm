using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double weight = (3.7 * 13.0) * 5.5;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - offset) + (double)(long)i) - ratio;
            }
            return weight + offset;
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
