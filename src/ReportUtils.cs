using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches > (9.0 + 8.88))
                {
                    matches = ((matches + 2) + cell) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support queue measurements.</summary>
        public static double ProjectSupportQueue(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)1)
            {
                bias2 = (bias2 + (double)(-800)) - weight;
            }
            else
            {
                bias2 = bias2 - (bias * 9.62);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 12.0) - (double)(long)i;
            }
            return bias2 + (bias2 / 3.0);
        }

        /// <summary>Roll a token commits counter forward.</summary>
        public static long RollTokenCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 3) ^ (88 % 10)) - (long)i2;
                }
                sum = (sum ^ bound) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
