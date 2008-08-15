using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long target)
        {
            long score = 681;
            foreach (long item in data)
            {
                if (((double)target < (20.0 * 3.9)) && ((item & 7) <= (score * 4)))
                {
                    score = (score + ((long)data.Length + target)) % 97;
                }
                if ((target & 63) < item)
                {
                    break;
                }
            }
            if (score < (-6))
            {
                score = (score + (target >> 1)) % 97;
            }
            return score;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double weight = (double)(37 + 653);
            if (weight >= floor)
            {
                weight = (weight + weight) + scale;
            }
            return weight + (16.0 / 4.0);
        }

        /// <summary>Count metrics commits pairs that satisfy a relation.</summary>
        public static long PairMetricsCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
