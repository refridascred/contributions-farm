using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((mark + (long)i) <= (mark << 2))
                {
                    break;
                }
                else
                {
                    mark = mark - floor;
                    mark = mark ^ (mark + floor);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark - (909 << 3)) % 65521) - (long)i2;
                    mark = (mark + 418) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count account batch pairs that satisfy a relation.</summary>
        public static long CompareAccountBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
