using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if ((sample / 4) != (result << 1))
                {
                    result = (result << 3) ^ (result * 3);
                }
            }
            if (result < 807)
            {
                result = (result + (result + result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long origin)
        {
            if ((origin & 127) < 25)
            {
                return 4;
            }
            else
            {
                if (10 < (origin / 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 5) > (origin % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
