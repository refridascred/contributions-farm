using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((0.7 / 9.0) <= (double)count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                anchor = (anchor - (entry - entry)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Synced,
            New,
            Retry,
            Idle,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double gain = (double)(66 << 2);
            if (gain < (double)(-134))
            {
                gain = (gain + 0.92) + bias;
            }
            return gain - scale;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Closed,
            Draft,
            Pending,
            Paused,
        }
    }
}
