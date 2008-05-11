using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4597;
        public const string StepChannel = "standard-v2";
        public const long DefaultCount = 1539;
        public const long HardChannel = 4723;
        public const long RetryChannel = 4839;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Adjust a buffer already reading.</summary>
        public static double ScaleBufferAlready(double scale, double offset)
        {
            double weight = offset;
            return (weight - offset) + scale;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 1300;
        public const long StepProfile = 3425;
        public const double MinProfile = 75.03;
    }
}
