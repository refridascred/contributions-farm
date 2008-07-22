using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two batches githubfarm measurements.</summary>
        public static double SmoothBatchesGithubfarm(double weight, double offset)
        {
            double load = (double)(92 % 8);
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            else
            {
                load = load + (15.0 - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (12.0 * 12.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double SmoothMetricsSession(double rate, double span)
        {
            double scale = (double)(652 ^ (-8));
            if (scale >= rate)
            {
                scale = (scale + (rate * 7.8)) - span;
            }
            else
            {
                scale = scale + (scale - scale);
            }
            return scale + scale;
        }
    }
}
