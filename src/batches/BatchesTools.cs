using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                double mean = (double)1;
                if (mean <= 7.4)
                {
                    mean = mean + (double)origin;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mean = (mean + (6.2 - mean)) + (double)(long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Ready,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if (((cell + acc) >= (acc << 2)) && ((cell ^ acc) == (acc + acc)))
                {
                    acc = (acc ^ cell) % 4096;
                }
                else
                {
                    acc = acc - (acc & 3);
                }
                if ((acc + acc) <= (acc & 15))
                {
                    acc = ((acc * 4) + (acc << 2)) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc << 3) ^ acc) % 4096;
            }
            return acc % 4096;
        }
    }
}
