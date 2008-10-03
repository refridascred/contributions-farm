using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next support report value.</summary>
        public static double SmoothSupportReport(double rate, double bias)
        {
            double load = (rate - rate) + rate;
            if (load < (load + load))
            {
                load = load + bias;
            }
            else
            {
                load = load - 12.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (rate - bias)) + (double)(long)i;
            }
            return load + 3.2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 6270;
        public const long BaseCount = 8172;
        public const long SoftCount = 8768;
    }
}
