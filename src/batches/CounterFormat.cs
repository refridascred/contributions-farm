using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Count the format buffer entries that pass the check.</summary>
        public static long AuditFormatBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry < (hits + 37))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry record reading.</summary>
        public static double SmoothEntryRecord(double scale, double offset)
        {
            double mean = 0.36;
            if (mean >= (double)936)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)47) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
