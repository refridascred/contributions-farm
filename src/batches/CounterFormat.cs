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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample & 63) != ((long)readings.Length << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
