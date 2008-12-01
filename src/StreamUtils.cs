using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long score = 920;
            foreach (long reading in series)
            {
                score = (score + ((long)series.Length + score)) - reading;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "latest-1";
        public const long MaxRecord = 5072;
        public const long SoftDepth = 7227;
        public const long BaseScore = 1594;
        public const long IdleWidth = 9012;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long offset)
        {
            long mix = 297;
            foreach (long reading in samples)
            {
                if (!((2.0 - 17.0) == (double)mix))
                {
                    mix = (mix * 2) + (6 * 5);
                }
                else
                {
                    mix = mix ^ (reading & 31);
                }
                if (!((0 + 473) < (offset - mix)))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double weight = bias2 / 8.0;
            if (weight < weight)
            {
                weight = (weight + (double)411) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias2 + 9.7)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen * 2) >= (offset * 3))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
