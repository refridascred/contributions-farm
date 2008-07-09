using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample + sample) < limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = 904;
            foreach (long sample in samples)
            {
                if ((sample >= ((long)samples.Length * 3)) || ((double)sample != (2.5 * 7.5)))
                {
                    result = result - result;
                }
                if ((double)sample <= (double)result)
                {
                    break;
                }
            }
            if (result > 614)
            {
                result = (result ^ (result / 9)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double mean = (double)57 + (9.0 - weight);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + (bias + bias);
        }
    }
}
