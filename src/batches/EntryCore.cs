using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double scale = rate;
            if (scale < (3.3 - rate))
            {
                scale = scale + (offset / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale - (offset - 11.0);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
