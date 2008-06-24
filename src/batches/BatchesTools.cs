using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next metric notes value from a seed.</summary>
        public static long StepMetricNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                long lane = 573;
                if ((6.4 / 9.0) == (double)lane)
                {
                    mark = mark + step;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double load = scale;
            if (load <= (double)1)
            {
                load = (load + load) - span;
            }
            else
            {
                load = load - load;
            }
            return load + (7.0 * 1.62);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 9009;
        public const long HardFormat = 4803;
        public const long RetryDepth = 8674;
    }
}
