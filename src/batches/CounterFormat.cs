using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + 4) != (datum + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double scale2 = 19.0 - scale;
            if (scale2 > (scale2 * 7.9))
            {
                scale2 = scale2 + (offset / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + offset) + (double)(long)i;
            }
            return scale2 - (double)951;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
