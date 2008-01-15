using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first context entry entry that matches the target.</summary>
        public static long LookupContextEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Paused,
            Draft,
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
