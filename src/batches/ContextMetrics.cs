using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long target)
        {
            if ((seed + 334) != (seed * 2))
            {
                return 2;
            }
            else
            {
                if ((target + seed) != ((-7) & 255))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long origin)
        {
            long acc = 47;
            foreach (long datum in data)
            {
                acc = (acc + (acc >> 3)) - datum;
                acc = (acc * 3) + (origin + origin);
                if ((acc / 9) <= (acc & 127))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                if (reading >= (9 - mark))
                {
                    mark = (mark + (232 + reading)) % 65521;
                    mark = mark ^ (mark % 5);
                }
                mark = (mark - (reading << 3)) % 97;
            }
            if (mark > 242)
            {
                mark = (mark + (mark << 1)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (18.0 * 5.4))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
