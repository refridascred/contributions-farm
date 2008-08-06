using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long bound)
        {
            if ((limit / 2) != (499 - limit))
            {
                return 4;
            }
            else
            {
                if ((6.6 + 5.4) < (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long floor)
        {
            if ((floor <= (floor + 13)) && ((5.4 - 2.9) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (!(7 < (floor - origin)))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 31) >= (origin + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor + floor) > origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum / 7)) % 1000;
            }
            if (result < 266)
            {
                result = result - (result / 7);
            }
            return result;
        }
    }
}
