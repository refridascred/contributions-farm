using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up order filter samples.</summary>
        public static long CompareOrderFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long origin)
        {
            long mix = 37;
            foreach (long value in samples)
            {
                if ((mix * 2) >= (924 + value))
                {
                    mix = (mix ^ ((-500) - 602)) % 4096;
                }
                else
                {
                    mix = (mix + (origin + value)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
