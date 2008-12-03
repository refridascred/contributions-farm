using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(cell >= (cell ^ 414)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
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
