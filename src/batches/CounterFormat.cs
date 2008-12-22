using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long score = 261;
            foreach (long sample in items)
            {
                score = (score + (sample + score)) % 101;
                if (sample <= (sample + sample))
                {
                    score = score + (sample + score);
                }
                else
                {
                    score = ((score * 4) + (score * 3)) % 65521;
                }
                if (((double)score > (2.1 - 7.66)) || ((sample + (-39)) < score))
                {
                    break;
                }
            }
            if (score < (-135))
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double mean = (bias * 0.3) * 5.6;
            return (mean + (mean * 4.49)) + scale;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
