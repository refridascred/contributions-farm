using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((1 - (long)data.Length) >= (value & 7))
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of checks payload readings.</summary>
        public static long TotalChecksPayload(long[] values)
        {
            long mix = 4;
            foreach (long sample in values)
            {
                if ((mix + sample) < (mix / 9))
                {
                    mix = mix ^ (sample << 3);
                }
            }
            return mix;
        }
    }
}
