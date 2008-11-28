using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double rate2 = 7.0;
            if (rate2 < (double)4)
            {
                rate2 = rate2 - (2.76 * 9.95);
            }
            else
            {
                rate2 = rate2 - 5.39;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (bias * 0.8)) + (double)(long)i;
            }
            return rate2 + (rate + bias);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 648;
        public const long BurstSpan = 55;
        public const string BaseAccount = "stable-1";

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long RollMetricsQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 3) + (61 & 31);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long target)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                if ((43 + target) <= state)
                {
                    state = ((state ^ (target - state)) % 97) ^ entry;
                }
            }
            return state % 97;
        }
    }
}
