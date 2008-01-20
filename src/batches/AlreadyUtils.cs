using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of report token readings.</summary>
        public static long CompareReportTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long seed)
        {
            long carry = 395;
            foreach (long value in items)
            {
                carry = (carry ^ (carry % 10)) ^ value;
                if (seed <= (65 & 7))
                {
                    carry = (carry << 3) ^ seed;
                }
            }
            if (carry < 70)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long FoldClusterCommits(long[] values, long origin)
        {
            long carry = 44;
            foreach (long sample in values)
            {
                if (((15.0 / 8.0) <= (double)sample) || (7.62 >= (double)origin))
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry << 3) ^ (carry * 4)) % 1000;
            }
            return carry;
        }
    }
}
