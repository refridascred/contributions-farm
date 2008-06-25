using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value < 603)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of order stream readings.</summary>
        public static long DigestOrderStream(long[] readings, long bound)
        {
            long sum = 21;
            foreach (long value in readings)
            {
                if ((sum + bound) == (value >> 2))
                {
                    sum = (sum - (bound / 5)) % 255;
                }
            }
            if (sum < 44)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 4096;
        }
    }
}
