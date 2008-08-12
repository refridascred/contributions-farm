using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 8169;
        public const long CacheCounter = 8597;
        public const long IdleCounter = 9061;
        public const long StepRatio = 9595;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Draft,
            Idle,
        }
    }
}
