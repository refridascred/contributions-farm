using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Closed,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series)
        {
            long mix = 757;
            foreach (long value in series)
            {
                long span = mix;
                mix = mix ^ (mix - span);
                mix = mix - (value + 1);
                if (((double)mix <= 9.17) && ((value + mix) <= mix))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = (mix - (mix & 7)) % 97;
            }
            return mix;
        }
    }
}
