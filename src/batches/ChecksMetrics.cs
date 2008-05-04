using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits * 4) < (hits - (-9)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((reading * 2) <= tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading > 687)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 - 0.46) > (double)(long)i)
                {
                    anchor = (anchor * 3) + anchor;
                }
                anchor = (anchor + ((long)i - anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics commits entries.</summary>
        public static long FoldMetricsCommits(long[] samples, long seed)
        {
            long score = 469;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score << 2) ^ seed) - (long)i;
                    score = (score + (seed << 1)) % 255;
                }
                if ((score >= (seed + seed)) || ((sample % 5) >= score))
                {
                    score = (score - (score * 3)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (sample * 3)) % 4096;
                }
            }
            if (score > 81)
            {
                score = (score + seed) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long result = -23;
            foreach (long cell in values)
            {
                if ((cell * 3) <= (result * 5))
                {
                    result = (result ^ cell) % 97;
                }
                else
                {
                    result = ((result * 3) + (result & 31)) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
