using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload contributi series from a seed.</summary>
        public static long IteratePayloadContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = score + score;
                if ((long)i < score)
                {
                    score = (score - bound) % 65521;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
