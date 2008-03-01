using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long state = -551;
            foreach (long cell in levels)
            {
                if (origin >= (state + cell))
                {
                    state = (state + (origin & 255)) % 101;
                }
            }
            if (state < 9)
            {
                state = (state + (origin & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double gain2 = 4.77;
            if (gain2 > 7.3)
            {
                gain2 = ((gain2 + (gain2 / 3.0)) - gain) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (gain2 / 2.0)) - (double)(long)i;
            }
            return gain2 - 4.0;
        }
    }
}
