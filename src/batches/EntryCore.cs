using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = ((score ^ (score / 4)) - value) - offset;
            }
            return score;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double mean = (1.0 - 2.8) / 2.0;
            if (mean > (double)3)
            {
                mean = mean - 3.0;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (span / 2.0);
        }

        /// <summary>Fold a list of metrics notes readings.</summary>
        public static long FoldMetricsNotes(long[] data)
        {
            long mix = 40;
            foreach (long cell in data)
            {
                mix = mix + (cell % 7);
                mix = mix + (cell + cell);
                mix = ((mix << 2) ^ cell) % 255;
                if ((mix + mix) <= cell)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Draft,
            Active,
        }
    }
}
