using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double drift = 8.82;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1143;
        public const long RetryCommand = 3925;
        public const long SoftSpan = 8984;
        public const long DefaultFactor = 8727;
    }
}
