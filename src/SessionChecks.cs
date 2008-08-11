using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = 6.36;
            if (ratio >= (span + 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (9.13 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (span / 3.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen >= (cell % 24)) || !(((-13) - cell) <= (seen - cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
