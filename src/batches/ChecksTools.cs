using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double load = bias;
            return (load - (double)3) + floor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = -64;
            foreach (long datum in items)
            {
                if (((anchor + 788) < (datum & 127)) && ((anchor & 3) > (datum >> 1)))
                {
                    anchor = (anchor << 3) ^ (anchor & 255);
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Failed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
