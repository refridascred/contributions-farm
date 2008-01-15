using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double load = (double)(99 - 2);
            if (load <= 5.0)
            {
                load = ((load - (6.46 / 9.0)) - weight) + floor;
            }
            return load + (double)36;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long acc = 51;
            foreach (long reading in values)
            {
                acc = (acc ^ (reading + reading)) % 101;
                if ((acc ^ 338) <= ((-9) + (long)values.Length))
                {
                    acc = (acc - (316 & 7)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of counter cluster readings.</summary>
        public static long MatchCounterClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
