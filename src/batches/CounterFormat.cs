using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 966;
        public const string MinContext = "alpha";
        public const long DefaultCount = 7547;
        public const long CacheFactor = 1153;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long offset)
        {
            if (!(479 >= (offset ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((limit >> 2) >= (limit - limit))
                {
                    return 7;
                }
                else
                {
                    if (!(19.0 <= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.7 * 3.06) >= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
