using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many githubfarm farm samples are out of range.</summary>
        public static long TallyGithubfarmFarmOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((9.5 + 8.31) != (double)(long)series.Length)
                {
                    tally = ((tally + 3) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + ((long)i2 / 8)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
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
