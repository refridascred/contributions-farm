using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)bound >= (4.72 - 6.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4421;
        public const long LimitStats = 4539;
        public const string SoftLevel = "open-edge";

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long AuditFormatCommandOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry * 5) >= tally) || (entry <= (entry ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long WeighGithubfarmSupport(long[] series, long bound)
        {
            long acc = 18;
            foreach (long cell in series)
            {
                acc = (((acc << 3) ^ cell) % 101) + bound;
            }
            if (acc < 586)
            {
                acc = (acc + (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Locked,
            Failed,
            New,
            Done,
        }
    }
}
