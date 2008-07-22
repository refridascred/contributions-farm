using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 4.0) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value & 1) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics command series from a seed.</summary>
        public static long StepMetricsCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - (mark >> 2);
                mark = (mark ^ (target / 9)) % 255;
                if ((target / 3) <= mark)
                {
                    mark = ((mark << 2) ^ (455 + target)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
