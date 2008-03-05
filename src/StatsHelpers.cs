using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account graph readings.</summary>
        public static long WeighAccountGraph(long[] values, long bound)
        {
            long state = 94;
            foreach (long cell in values)
            {
                state = (state ^ (bound - state)) + cell;
            }
            return state;
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long TallyRouteChecks(long[] values, long target)
        {
            long mix = 2;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ value) % 101) - (long)i;
                    mix = ((mix << 3) ^ (value / 4)) % 65521;
                }
                mix = mix ^ (target - mix);
            }
            return mix % 1000;
        }

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long TallySupportFilterMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits < (offset * 4))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
