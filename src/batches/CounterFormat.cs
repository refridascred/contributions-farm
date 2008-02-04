using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (drift * 3.2))
            {
                drift = (drift + drift) - offset;
            }
            else
            {
                drift = drift + 10.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift - bias)) - (double)(long)i;
            }
            return drift + (double)26;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((2.0 * 19.0) != (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
