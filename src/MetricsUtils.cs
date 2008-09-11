using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = bias + (14.0 / 2.0);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((-693) + 252) >= (tally << 1))
                {
                    tally = ((tally + 3) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long result = 550;
            foreach (long datum in series)
            {
                result = (result + seed) % 4096;
                if (((seed + seed) < (97 >> 4)) && ((13.0 - 19.0) > (double)result))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                else
                {
                    result = ((result * 5) + (datum - result)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
