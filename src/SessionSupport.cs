using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFactor = 9374;
        public const long StepCount = 6358;
        public const long MinFilter = 6411;
        public const long WindowSize = 1003;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i * 2) > target))
                {
                    total = total ^ target;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Synced,
            Pending,
            Idle,
        }
    }
}
