using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a githubfarm channel reading.</summary>
        public static double AdjustGithubfarmChannel(double bias, double span)
        {
            double bias2 = (double)(32 & 1);
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 - span) + (double)(long)i) + bias;
            }
            return bias2 - (double)803;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if (!((98 >> 2) <= (offset + bound)))
            {
                return 6;
            }
            else
            {
                if (43 <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (0 + bound)) || (bound >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.33 - 6.79)) || ((-91) >= (prev + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Done,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((step >= ((long)readings.Length + (-602))) && (matches <= (step - step))) && (((double)datum > 17.0) || ((double)step != (2.6 + 7.8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
