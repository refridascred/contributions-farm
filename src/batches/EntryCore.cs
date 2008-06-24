using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double span)
        {
            double mean = ratio - (span + ratio);
            return mean + (7.1 / 4.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 94.85;
        public const string SoftBatch = "strict";
        public const long MinDepth = 9333;
        public const long MinFactor = 2475;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Done,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every record buffer entry stays within the limit.</summary>
        public static bool CheckRecordBufferBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
