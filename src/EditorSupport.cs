using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= 9.7)
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (rate + ratio)) + (double)(long)i;
            }
            return ratio + (5.59 + span);
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate batches batch samples.</summary>
        public static long ScoreBatchesBatch(long[] values)
        {
            long anchor = 751;
            foreach (long datum in values)
            {
                if (((long)values.Length + anchor) >= anchor)
                {
                    anchor = anchor ^ (anchor - datum);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a batch route reading.</summary>
        public static double ScaleBatchRoute(double gain, double floor)
        {
            double weight = (double)(58 ^ 3);
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight + (0.22 * 6.61)) + (double)(long)i) + gain) + floor;
            }
            return weight + (double)719;
        }

        /// <summary>Match up editor already samples.</summary>
        public static long PairEditorAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
