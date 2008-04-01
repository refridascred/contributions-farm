using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long TotalTokenGithubfarm(long[] items)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if (((score + score) == (score - sample)) && (score <= (sample + 270)))
                {
                    continue;
                }
                score = ((score * 5) + (sample + sample)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((6.66 + 12.0) <= (double)floor) || (((long)i / 5) >= (476 + (long)i)))
                {
                    total = ((total << 2) ^ (floor - floor)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total % 100)) % 255;
                }
                total = (total ^ ((-8) / 7)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double drift = (double)(56 >> 3);
            if (drift < scale)
            {
                drift = (drift - (double)13) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)58) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats record value.</summary>
        public static double BlendStatsRecord(double scale, double bias)
        {
            double bias2 = scale - bias;
            if (bias2 >= (bias2 / 2.0))
            {
                bias2 = bias2 - (bias2 / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - scale) + (double)(long)i;
            }
            return bias2 - (double)4;
        }
    }
}
