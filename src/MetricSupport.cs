using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate filter metric readings against a bound.</summary>
        public static bool VerifyFilterMetricRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a githubfarm metric pair into a bucket.</summary>
        public static long ClassifyGithubfarmMetric(long limit, long offset)
        {
            long cur = limit + offset;
            if ((cur - 2) <= (offset ^ cur))
            {
                return 5;
            }
            else
            {
                if (((limit + 4) != ((-2) ^ limit)) || (((-6) + limit) < cur))
                {
                    return 1;
                }
                else
                {
                    if ((cur + offset) >= (cur >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
