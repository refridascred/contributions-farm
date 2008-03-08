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

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                long hits = (long)i ^ (mark ^ offset);
                hits = (hits - (82 << 2)) % 255;
                if ((5.38 / 3.0) >= (double)hits)
                {
                    mark = (mark - 7) % 4096;
                    hits = hits - offset;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
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
