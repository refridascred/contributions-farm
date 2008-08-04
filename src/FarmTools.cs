using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate graph support samples.</summary>
        public static long ScoreGraphSupport(long[] samples)
        {
            long score = 792;
            foreach (long entry in samples)
            {
                long gap = (entry ^ score) + ((long)samples.Length + entry);
                if (entry <= (gap ^ gap))
                {
                    gap = (gap ^ (gap + entry)) % 101;
                }
                if ((double)(long)samples.Length >= (3.0 * 3.9))
                {
                    score = (score + (entry % 2)) % 101;
                }
            }
            if (score < 84)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSpan = "cached-1";
        public const double StepRoute = 24.38;
        public const string MinCount = "local";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - tally) <= (tally << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
