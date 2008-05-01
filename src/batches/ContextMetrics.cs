using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((offset + offset) > state))
                {
                    state = (state ^ (state + 89)) % 255;
                    state = state - (offset / 6);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long step)
        {
            if ((double)floor > 6.6)
            {
                return 0;
            }
            else
            {
                if ((step % 5) < 3)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 7.6) > (double)reading)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long TallyCommandFarm(long[] readings, long target)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if (!((4 - sum) <= target))
                {
                    sum = (((sum << 2) ^ ((long)readings.Length * 2)) % 4096) + entry;
                }
            }
            return sum % 65521;
        }
    }
}
