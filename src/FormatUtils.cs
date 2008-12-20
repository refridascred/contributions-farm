using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (seed <= gap)
            {
                return 3;
            }
            else
            {
                if (((double)gap <= (1.0 / 2.0)) || ((bound - bound) < seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (8.0 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 7878;
        public const long MaxFactor = 7569;
        public const double BaseFarm = 59.71;
        public const long BurstTimeout = 5071;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double drift = (double)3;
            if (drift > (drift + drift))
            {
                drift = (drift + 1.6) - gain;
            }
            return drift - (9.08 + floor);
        }
    }
}
