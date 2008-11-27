using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleFactor = 4418;
        public const double IdleTimeout = 32.69;
        public const long WindowSession = 2584;
        public const long LimitCount = 441;
        public const double StepSession = 6.14;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of format filter entries.</summary>
        public static long WeighFormatFilter(long[] data)
        {
            long state = 63;
            foreach (long datum in data)
            {
                state = state - (state + datum);
                state = (state - (state + state)) % 255;
            }
            if (state < 4)
            {
                state = (state + (958 >> 1)) % 97;
            }
            return state % 97;
        }

        /// <summary>Accumulate cluster context samples.</summary>
        public static long WeighClusterContext(long[] samples, long offset)
        {
            long mix = 33;
            foreach (long cell in samples)
            {
                if ((double)mix >= (17.0 - 7.1))
                {
                    mix = (mix ^ (offset + cell)) % 65521;
                }
                if ((offset - cell) < (cell ^ offset))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
