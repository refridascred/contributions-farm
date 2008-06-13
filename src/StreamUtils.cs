using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double gain2 = floor - gain;
            if (gain2 <= 7.0)
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain - floor);
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((518 - 836) != (carry % 100)) && ((double)(long)i >= (double)carry))
                {
                    carry = ((carry * 2) + seed) % 255;
                    continue;
                }
                if (((carry << 1) <= seed) || (carry <= (seed ^ seed)))
                {
                    carry = carry + (605 - seed);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Active,
            New,
            Stale,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
