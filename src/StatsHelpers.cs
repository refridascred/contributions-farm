using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a profile commits figure with a bias.</summary>
        public static double BlendProfileCommits(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (bias2 / 6.0))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - bias;
        }

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
