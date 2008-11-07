using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean <= floor)
            {
                mean = mean + (double)835;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 1.2)) + (double)(long)i;
            }
            return mean - (scale + scale);
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Blend two queue contributi measurements.</summary>
        public static double AdjustQueueContributi(double rate, double span)
        {
            double weight = (span - rate) + (double)8;
            return weight - 1.3;
        }
    }
}
