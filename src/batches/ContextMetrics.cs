using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long bound)
        {
            if (!((bound / 7) >= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if ((bound - bound) <= floor)
                {
                    return 1;
                }
                else
                {
                    if (((floor + bound) <= (floor << 2)) || (bound > (84 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
