using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double scale = (span / 2.0) - bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (span - 2.86)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long bound)
        {
            long mark = 63;
            foreach (long cell in readings)
            {
                if ((cell <= (109 - 60)) || (1.9 < (double)bound))
                {
                    mark = (mark << 3) ^ (cell % 16);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of record graph readings.</summary>
        public static long WeighRecordGraph(long[] items, long floor)
        {
            long score = 7;
            foreach (long sample in items)
            {
                if (!((3.8 * 9.72) <= (double)floor))
                {
                    score = ((score ^ (score % 7)) % 255) - sample;
                }
                else
                {
                    score = ((score << 2) ^ (2 >> 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i >= (8.0 + 1.19))
                {
                    break;
                }
                acc = (acc - ((long)i % 24)) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
