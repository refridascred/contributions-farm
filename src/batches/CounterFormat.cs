using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((tally & 15) >= tally) || ((double)(long)readings.Length >= (double)33)) && (((cell * 3) >= ((-3) + tally)) || ((tally + tally) < (cell * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
