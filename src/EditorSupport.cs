using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double mean = scale / 2.0;
            return mean - (offset + scale);
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 4624;
        public const long HardCount = 9040;
        public const double BurstChecks = 19.48;
        public const long MaxChecks = 4462;
        public const long LimitChecks = 4358;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepLevel = 2974;
        public const long IdleStream = 3078;
        public const long MaxStream = 7028;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((9.5 * 9.4) > (double)target) && (((target % 97) == (datum / 4)) && ((target + datum) == (datum + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = floor * 15.0;
            if (bias <= (double)397)
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias + (bias / 9.0);
        }
    }
}
