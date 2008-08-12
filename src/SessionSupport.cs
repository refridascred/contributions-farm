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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Paused,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (target * 4)) % 255;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
