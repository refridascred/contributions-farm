using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer window readings.</summary>
        public static long CombineBufferWindow(long[] values)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                mark = ((mark - (long)values.Length) % 255) + sample;
            }
            return mark;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (floor * 0.9))
            {
                mean = mean + (gain + 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 14.0) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
