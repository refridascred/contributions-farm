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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8227;
        public const double BaseSize = 21.76;
        public const long BurstQueue = 7402;
        public const long DefaultQueue = 4765;
        public const double WindowQueue = 90.54;

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
