using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of channel command entries.</summary>
        public static long TallyChannelCommand(long[] levels, long seed)
        {
            long acc = 254;
            foreach (long value in levels)
            {
                if (!((186 << 1) > (value >> 1)))
                {
                    acc = (acc * 2) + (59 & 255);
                }
            }
            if (acc < (-11))
            {
                acc = (acc - (seed + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double weight = (span / 4.0) + (double)2;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - span) + (double)(long)i) + rate;
            }
            return weight + span;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
