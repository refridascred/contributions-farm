using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double scale = (bias + 9.01) - (bias2 - bias);
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (bias + bias);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = bias + (8.6 - bias);
            return (load - load) + floor;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long state = -73;
            foreach (long sample in data)
            {
                state = (state ^ sample) - seed;
                if (state < (state * 3))
                {
                    state = state + (state / 9);
                }
                if ((4.4 * 8.5) != (double)sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a editor schema figure with a bias.</summary>
        public static double ProjectEditorSchema(double weight, double floor)
        {
            double drift = (double)(1 & 31);
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift + (double)675) - (double)(long)i) - weight) + floor;
            }
            return drift - drift;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
