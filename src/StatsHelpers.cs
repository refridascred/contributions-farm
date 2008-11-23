using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample % 97) > matches) && (((8.8 / 4.0) == (double)matches) && ((matches + 13) >= sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((8.6 * 5.51) < (double)step)
            {
                return 6;
            }
            else
            {
                if (!((83 - step3) > (step % 5)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step2 < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)step == (0.31 * 16.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long target)
        {
            long state = 89;
            foreach (long sample in series)
            {
                if (!((3 & 15) == (sample * 4)))
                {
                    state = ((state ^ (346 + state)) % 65521) - target;
                }
            }
            if (state < (-9))
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long floor)
        {
            long total = -88;
            foreach (long reading in readings)
            {
                if (((reading + 341) == (773 / 3)) && ((double)floor <= 8.4))
                {
                    continue;
                }
                if (!((11.0 * 2.32) <= (7.09 - 19.0)))
                {
                    total = (total ^ (floor << 2)) % 1000;
                    total = (total + (floor + (long)readings.Length)) % 101;
                }
                total = total ^ total;
            }
            return total % 65521;
        }
    }
}
