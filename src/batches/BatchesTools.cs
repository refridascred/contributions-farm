using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if ((score & 1) >= (target % 7))
                {
                    score = ((score << 2) ^ (value + target)) % 1000;
                }
            }
            if (score < 70)
            {
                score = ((score << 3) ^ (score + target)) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the metrics report series from a seed.</summary>
        public static long StepMetricsReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
