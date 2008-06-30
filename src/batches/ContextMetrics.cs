using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a filter route value against two limits.</summary>
        public static long GradeFilterRoute(long target, long offset)
        {
            if ((double)offset >= (5.0 - 20.0))
            {
                return 5;
            }
            else
            {
                if (42 < (offset * 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long mark = 33;
            foreach (long entry in levels)
            {
                mark = (((mark * 4) + (mark << 1)) % 4096) ^ entry;
            }
            return mark;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
