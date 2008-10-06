using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a checks support counter forward.</summary>
        public static long StepChecksSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i < (7.51 / 2.0))
                {
                    mix = ((mix * 3) + (77 - (long)i)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
