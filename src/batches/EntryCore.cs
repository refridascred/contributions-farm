using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (floor * 4.99))
            {
                ratio = ratio + (floor - ratio);
            }
            else
            {
                ratio = ratio + (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)82) + (double)(long)i;
            }
            return ratio + (2.76 / 5.0);
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepFactor = 31.87;
        public const string BatchAccount = "strict-edge";
        public const long MaxAccount = 6944;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((reading << 3) > reading) || ((count - reading) <= ((long)samples.Length - count))) && ((reading << 2) <= (count + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
