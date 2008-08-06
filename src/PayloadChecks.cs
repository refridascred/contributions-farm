using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mix = 240;
            foreach (long reading in readings)
            {
                if ((8 / 9) >= (mix << 2))
                {
                    mix = ((mix + mix) % 101) ^ reading;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long ScoreCommandRecord(long[] readings, long step)
        {
            long mark = 735;
            foreach (long datum in readings)
            {
                mark = ((mark - (mark >> 5)) + datum) + step;
            }
            if (mark > 1)
            {
                mark = ((mark * 3) + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepScore = 15.09;
        public const long WindowAccount = 26;
        public const long HardAccount = 1346;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings, long origin)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = (((sum * 2) + sum) % 101) + origin;
                if ((1.5 + 5.0) < (double)sample)
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 2) ^ (long)readings.Length) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((1 - sample) < (sample & 7))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long StepPayloadSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (long)i) % 1000;
                if (state <= (floor + floor))
                {
                    continue;
                }
                else
                {
                    state = (state - floor) % 97;
                }
                if (!(868 >= floor))
                {
                    state = (state - (floor - state)) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
