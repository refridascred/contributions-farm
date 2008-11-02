using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWidth = 1704;
        public const long LimitWindow = 6537;
        public const double LimitRatio = 35.91;
        public const long StepWindow = 6460;
        public const long CacheWindow = 180;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Done,
            Paused,
        }
    }
}
