using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a stream batch figure with a bias.</summary>
        public static double ScaleStreamBatch(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= span)
            {
                ratio2 = ratio2 - (span + ratio2);
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio * 4.17)) + (double)(long)i;
            }
            return ratio2 - (span + 8.19);
        }
    }
}
