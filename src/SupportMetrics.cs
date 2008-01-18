using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long offset, long floor)
        {
            long step = offset - floor;
            if (floor <= (floor ^ step))
            {
                return 5;
            }
            else
            {
                if ((step + offset) <= step)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = (state - 698) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long total = 88;
            foreach (long cell in readings)
            {
                if ((double)total <= (1.78 / 5.0))
                {
                    total = (total * 3) + (total + total);
                }
                if (!((3 << 2) > (total + cell)))
                {
                    break;
                }
                if ((target ^ total) <= (target >> 4))
                {
                    total = ((total * 4) + (cell + target)) % 1000;
                }
                else
                {
                    total = total - cell;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
