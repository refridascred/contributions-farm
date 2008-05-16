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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data, long target)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if (((-2) ^ target) != (target / 7))
                {
                    state = (((state << 3) ^ 9) % 4096) - sample;
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ (state & 127)) % 97;
            }
            return state % 97;
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

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                total = (total + sample) % 255;
            }
            return total % 65521;
        }
    }
}
