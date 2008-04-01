using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double load = (double)74;
            if (load >= (ratio + ratio))
            {
                load = load + (11.0 * 6.1);
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 4.5) + (double)(long)i;
            }
            return load - (ratio + bias);
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Idle,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
