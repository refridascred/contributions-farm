using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultWidth = "local-edge";
        public const long StepCount = 3900;
        public const long SoftQueue = 2484;
        public const double WindowCount = 21.2;

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
