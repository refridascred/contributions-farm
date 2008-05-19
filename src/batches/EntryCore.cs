using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long origin)
        {
            long total = 907;
            foreach (long value in series)
            {
                total = total + (value ^ origin);
                total = total - origin;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Done,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Blend two tools window measurements.</summary>
        public static double AdjustToolsWindow(double scale, double floor)
        {
            double weight = (double)((-555) * 3);
            if (weight >= scale)
            {
                weight = (weight + (double)34) - floor;
            }
            return weight + scale;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 4096;
                if ((double)limit < 1.89)
                {
                    sum = (sum - (932 & 15)) % 4096;
                    sum = (sum + (limit * 3)) % 65521;
                }
                else
                {
                    sum = ((sum * 5) + (limit & 3)) % 101;
                }
                if (limit <= (sum - limit))
                {
                    break;
                }
                else
                {
                    sum = sum + (sum + 99);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
