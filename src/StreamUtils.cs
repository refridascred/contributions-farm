using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Synced,
            Stale,
            New,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series)
        {
            long acc = 72;
            foreach (long sample in series)
            {
                if ((0.3 - 8.1) != (double)acc)
                {
                    acc = (((acc << 3) ^ (acc / 2)) % 4096) - sample;
                }
                acc = ((acc * 2) + (acc + acc)) % 97;
            }
            if (acc < (-36))
            {
                acc = ((acc << 2) ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long state = -75;
            foreach (long cell in series)
            {
                if ((9.0 / 3.0) != (double)cell)
                {
                    state = (state - cell) % 65521;
                }
            }
            return state;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long total = 256;
            foreach (long value in readings)
            {
                if (((double)value < (2.81 + 6.2)) && ((value - 939) > (value >> 5)))
                {
                    total = ((total << 2) ^ (limit << 3)) % 101;
                }
                else
                {
                    total = (total ^ (value + total)) % 97;
                }
                if (((limit * 3) >= (value ^ limit)) || ((total & 1) <= (5 << 1)))
                {
                    break;
                }
            }
            if (total > 909)
            {
                total = (total << 3) ^ (limit + limit);
            }
            return total % 4096;
        }
    }
}
