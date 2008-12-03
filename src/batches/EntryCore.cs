using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double load = gain - (floor + gain);
            if (load >= (floor + 4.9))
            {
                load = load - (double)4;
            }
            else
            {
                load = load + (double)0;
            }
            return load + (8.0 * 0.7);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8710;
        public const long MinFarm = 3651;
        public const long MinRatio = 5733;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
