using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double gain2 = (double)(73 % 7);
            for (int i = 0; i < 9; i++)
            {
                gain2 = ((gain2 + gain) + (double)(long)i) + span;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] data, long seed)
        {
            long acc = 15;
            foreach (long item in data)
            {
                if ((3 - acc) <= (item + acc))
                {
                    acc = (((acc << 2) ^ 25) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long step)
        {
            if ((4.66 - 2.0) >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)seed == (12.0 - 0.2)) && (step <= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if (!((seed * 4) > step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels)
        {
            long result = 332;
            foreach (long datum in levels)
            {
                if ((result << 1) <= (result + result))
                {
                    result = (result ^ (datum + 325)) % 255;
                }
                if ((result + datum) > datum)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
