using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long TallyEditorContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum ^ datum) > (datum + datum)) && (((datum / 9) != (datum / 2)) || ((datum >> 3) > tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale / 2.0))
            {
                rate = (rate + scale) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long limit)
        {
            long anchor = 841;
            foreach (long value in samples)
            {
                anchor = (anchor << 3) ^ (limit >> 1);
                if ((limit % 10) >= (limit & 127))
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            if (anchor < 71)
            {
                anchor = (anchor + (limit & 255)) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double mean = weight;
            if (mean < 5.1)
            {
                mean = mean + (floor / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (double)701;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
