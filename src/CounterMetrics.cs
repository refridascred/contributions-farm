using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double weight = 11.0;
            if (weight < (12.0 / 7.0))
            {
                weight = (weight - (weight / 2.0)) + span;
            }
            else
            {
                weight = weight + scale;
            }
            return weight - (scale + 3.69);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (origin & 255)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2.34 > (double)limit)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
