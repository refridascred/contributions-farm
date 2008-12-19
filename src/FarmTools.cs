using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate editor profile readings against a bound.</summary>
        public static bool VerifyEditorProfileBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = (mix * 3) + cell;
            }
            return mix;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
