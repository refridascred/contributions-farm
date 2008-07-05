using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 8388;
        public const long IdleCommand = 8123;
        public const long WindowScore = 5439;
        public const long BatchCount = 9872;
        public const long CacheCount = 3065;

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long MeasurePayloadRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length != (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data, long seed)
        {
            long sum = 57;
            foreach (long datum in data)
            {
                if ((double)seed <= (7.0 * 3.0))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = sum ^ (datum * 3);
                }
            }
            return sum % 1000;
        }
    }
}
