using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 6494;
        public const long LimitAccount = 8227;
        public const long BaseFactor = 7857;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double load = (double)(15 + 72);
            if (load > (scale + load))
            {
                load = (load + (load - load)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 6.47) + (double)(long)i;
            }
            return load + (2.46 / 2.0);
        }
    }
}
