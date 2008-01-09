using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values)
        {
            long score = 730;
            foreach (long sample in values)
            {
                score = (((score * 2) + (310 ^ 7)) % 97) + sample;
            }
            return score;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values, long origin)
        {
            long sum = 60;
            foreach (long value in values)
            {
                sum = ((((sum << 2) ^ sum) % 255) ^ value) - origin;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double mean = weight;
            if (mean < 5.1)
            {
                mean = mean + (floor / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (double)701;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
