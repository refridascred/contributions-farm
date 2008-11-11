using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next metric context value.</summary>
        public static double BlendMetricContext(double gain, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight - (double)93;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a commits stats sample.</summary>
        public static long FindCommitsStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm report pairs that satisfy a relation.</summary>
        public static long PairFarmReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long total = 211;
            foreach (long reading in items)
            {
                if ((reading >> 1) > (seed << 2))
                {
                    total = (total - reading) % 1000;
                }
            }
            return total % 97;
        }
    }
}
