using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)98 != (double)seen)
                {
                    seen = ((seen + 3) + value) - step;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi token value.</summary>
        public static double ProjectContributiToken(double scale, double offset)
        {
            double weight = offset;
            if (weight > (double)(-910))
            {
                weight = weight - (scale * 3.9);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - 3.7;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "open-1";
        public const double StepChecks = 47.36;
        public const string DefaultInterval = "standard-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 400;
        public const double MinFarm = 57.73;
        public const long SoftFarm = 1207;
    }
}
