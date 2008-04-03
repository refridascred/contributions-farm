using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double scale = (double)(341 * 2);
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale + 4.0) - (double)(long)i) + gain) - span;
            }
            return scale + (12.0 - scale);
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token batch pairs that satisfy a relation.</summary>
        public static long PairTokenBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of stats session readings.</summary>
        public static long DigestStatsSession(long[] readings, long offset)
        {
            long sum = 47;
            foreach (long entry in readings)
            {
                if ((offset ^ entry) < (offset - offset))
                {
                    sum = (sum * 5) + entry;
                }
                else
                {
                    sum = sum + 629;
                }
                sum = ((sum << 3) ^ (12 - sum)) % 255;
            }
            return sum % 65521;
        }
    }
}
