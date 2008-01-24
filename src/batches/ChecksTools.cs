using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two checks entry measurements.</summary>
        public static double AdjustChecksEntry(double gain, double floor)
        {
            double load = (double)(8 + 99);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (5.0 / 4.0)) + (double)(long)i) + floor;
            }
            return load - (gain * 1.94);
        }
    }
}
