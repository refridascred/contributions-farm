using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double load = (bias + bias) / 8.0;
            if (load > gain)
            {
                load = load - (double)6;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (load - gain);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double ratio2 = offset;
            return (ratio2 - (5.1 * 6.7)) + ratio;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Idle,
            Done,
        }
    }
}
