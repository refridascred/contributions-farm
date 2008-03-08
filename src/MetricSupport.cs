using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] samples)
        {
            long score = -8;
            foreach (long value in samples)
            {
                if ((score % 60) < 23)
                {
                    score = (score << 2) ^ score;
                }
                for (int i = 0; i < 12; i++)
                {
                    score = ((score + value) % 255) + (long)i;
                }
                score = score + (value << 1);
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading < (46 + reading))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
