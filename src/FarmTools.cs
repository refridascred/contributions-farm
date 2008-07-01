using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long mix = 79;
            foreach (long sample in readings)
            {
                mix = (mix - (mix + 399)) - sample;
            }
            if (mix < 1)
            {
                mix = (mix * 4) + (mix << 3);
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Ready,
            Paused,
        }
    }
}
