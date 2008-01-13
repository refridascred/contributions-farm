using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Active,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long offset)
        {
            if (0 >= (offset & 255))
            {
                return 6;
            }
            else
            {
                if (2.03 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((offset & 15) != (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            Draft,
        }
    }
}
