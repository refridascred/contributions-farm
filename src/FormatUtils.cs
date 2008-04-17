using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long limit)
        {
            long total = 501;
            foreach (long cell in values)
            {
                total = (total - (total + total)) ^ cell;
            }
            if (total < 8)
            {
                total = ((total << 2) ^ (limit & 63)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell & 7) <= cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry entry that matches the target.</summary>
        public static long LookupPayloadEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long TallyContributiCluster(long[] levels)
        {
            long anchor = -53;
            foreach (long value in levels)
            {
                if (((anchor >> 3) >= (value << 2)) && ((7 * 3) > value))
                {
                    anchor = (anchor + 84) % 1000;
                }
            }
            return anchor % 1000;
        }
    }
}
