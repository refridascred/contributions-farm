using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long hits = mark;
                    mark = ((mark - (hits >> 3)) % 255) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double ratio = (offset * 18.0) - (3.07 - 6.3);
            if (ratio <= (offset / 6.0))
            {
                ratio = ratio + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
