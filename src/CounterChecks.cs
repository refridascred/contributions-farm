using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data)
        {
            long mark = -64;
            foreach (long reading in data)
            {
                mark = ((mark - (mark << 2)) % 255) - reading;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -9;
            foreach (long cell in readings)
            {
                state = (state + cell) % 255;
                if ((cell ^ cell) > (cell * 2))
                {
                    state = state + (cell & 31);
                }
                else
                {
                    state = (state + (state >> 4)) % 4096;
                }
                if ((13 - cell) < cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Done,
            Ready,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((value * 4) != (limit & 15)) || ((count + limit) < value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long step)
        {
            long mix = 4;
            foreach (long value in readings)
            {
                if ((value + mix) >= (3 + step))
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            if (mix > (-25))
            {
                mix = (mix ^ (mix - 8)) % 1000;
            }
            return mix % 1000;
        }
    }
}
