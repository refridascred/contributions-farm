using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit report metric readings against a rule.</summary>
        public static long AuditReportMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (68 >= (tally - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double mean = offset;
            if (mean > (double)2)
            {
                mean = (mean - (mean * 20.0)) - gain;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (offset / 8.0);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 97) - reading;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
