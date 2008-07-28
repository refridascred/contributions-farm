using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double rate = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (3.9 + scale)) + (double)(long)i) - floor;
            }
            return rate - 4.8;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long state = -7;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = state ^ ((long)i % 97);
                }
                if (!((floor / 8) < (reading << 2)))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long target)
        {
            long gap = floor - target;
            if ((target >> 4) >= (target << 1))
            {
                return 6;
            }
            else
            {
                if (((double)52 <= (double)gap) && (gap <= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long CountSessionEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
