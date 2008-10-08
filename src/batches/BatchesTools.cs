using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = 287;
            foreach (long sample in readings)
            {
                if (((sample >> 4) == (969 & 127)) && ((sample / 5) < (mix ^ sample)))
                {
                    mix = (mix * 3) + (sample ^ mix);
                }
                if ((long)readings.Length <= sample)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
