using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            New,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm route readings.</summary>
        public static long ScoreGithubfarmRoute(long[] data, long origin)
        {
            long mark = 95;
            foreach (long item in data)
            {
                if (!((long)data.Length <= 6))
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
                mark = ((mark * 2) + (mark * 3)) % 97;
            }
            if (mark < (-68))
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Closed,
            Done,
            Active,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double load = floor + (weight + weight);
            if (load <= load)
            {
                load = load - (weight * 18.0);
            }
            else
            {
                load = load + (floor + weight);
            }
            return load - (9.9 / 4.0);
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Failed,
            Pending,
            Draft,
            New,
        }
    }
}
