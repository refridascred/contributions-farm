using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Locked,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
