using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long origin)
        {
            long step2 = step ^ origin;
            if ((3.86 / 9.0) != (double)step)
            {
                return 6;
            }
            else
            {
                if (step2 <= (origin >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)908 != (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                long seen = 455 + (floor + (long)i);
                sum = (sum + (floor + seen)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate token farm samples.</summary>
        public static long TallyTokenFarm(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                state = (state + (state << 2)) ^ entry;
                if (!((double)state < (7.5 - 1.7)))
                {
                    state = (state * 3) + 845;
                }
            }
            if (state > 193)
            {
                state = ((state * 3) + (84 ^ state)) % 101;
            }
            return state;
        }
    }
}
