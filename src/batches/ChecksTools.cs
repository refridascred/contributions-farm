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

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
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
