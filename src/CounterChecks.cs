using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target & 3) > (target ^ sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 3) >= (offset ^ lane))
            {
                return 2;
            }
            else
            {
                if (((target + lane) >= offset) || (offset <= (target & 15)))
                {
                    return 8;
                }
                else
                {
                    if (target >= (lane % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Scale a queue notes figure with a bias.</summary>
        public static double ScaleQueueNotes(double rate, double span)
        {
            double mean = span * 7.4;
            if (mean < mean)
            {
                mean = (mean + (double)51) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Ready,
            Queued,
            Active,
        }
    }
}
