using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values, long target)
        {
            long sum = 9;
            foreach (long item in values)
            {
                sum = sum - (sum * 2);
                if ((item << 2) == (target & 63))
                {
                    sum = (sum + (target + sum)) % 4096;
                }
            }
            if (sum < 498)
            {
                sum = (sum << 3) ^ (sum + (long)values.Length);
            }
            return sum % 1000;
        }

        /// <summary>Scale a stats report figure with a bias.</summary>
        public static double ProjectStatsReport(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (floor - floor))
            {
                gain = (gain - floor) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)21;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen ^ seen) < (seen / 7))
                {
                    seen = ((seen + 3) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up entry support samples.</summary>
        public static long MatchEntrySupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = 897;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + (acc << 1)) % 1000) ^ reading;
            }
            return acc % 97;
        }
    }
}
