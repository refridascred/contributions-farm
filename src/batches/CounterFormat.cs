using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Retry,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (mark - (-43))) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
