using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long MeasureMetricsSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) > ((long)values.Length / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if ((step + step) > (step - limit))
            {
                return 4;
            }
            else
            {
                if ((6.49 + 1.1) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((origin & 31) == ((-168) ^ matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
