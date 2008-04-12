using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double gain = (double)((-5) - 2);
            return ((gain + 17.0) + bias) + offset;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long score = 47;
            foreach (long datum in values)
            {
                if ((double)score < 0.1)
                {
                    score = (score * 3) + (score + score);
                }
                if (!((500 + (long)values.Length) > datum))
                {
                    score = (score - (score + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long PairLayoutAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9741;
        public const string MinRatio = "latest";
        public const double RetryBuffer = 85.76;
        public const string CacheBuffer = "legacy-1";
        public const long BaseBuffer = 8250;

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 3) ^ carry) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
