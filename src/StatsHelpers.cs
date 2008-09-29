using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count order notes pairs that satisfy a relation.</summary>
        public static long MatchOrderNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload farm samples.</summary>
        public static long TotalPayloadFarm(long[] items)
        {
            long score = 731;
            foreach (long reading in items)
            {
                score = (score ^ (score + reading)) % 97;
            }
            if (score > (-327))
            {
                score = ((score << 3) ^ (score & 127)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double rate = floor;
            if (rate > 2.83)
            {
                rate = rate - 7.0;
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor * 5.3)) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 6218;
        public const long MinLayout = 2535;
        public const double MaxLayout = 15.4;
        public const long BatchLayout = 7822;
        public const long HardLayout = 9562;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Dropped,
            Active,
            Paused,
            Synced,
        }
    }
}
