using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 12.19;
        public const long IdleRecord = 4319;
        public const long SoftDepth = 5363;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftTimeout = 13.68;
        public const long DefaultDepth = 1810;
        public const long SoftAlready = 5665;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = ((state * 3) + (state & 63)) % 65521;
                state = (state + (5 % 24)) % 4096;
                if (((state % 100) > datum) && ((3.0 * 2.0) < (double)state))
                {
                    state = (state + (979 >> 3)) % 1000;
                }
                else
                {
                    state = (state ^ (datum * 2)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
