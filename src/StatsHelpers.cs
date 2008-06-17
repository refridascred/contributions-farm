using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long target)
        {
            if (limit > (target >> 4))
            {
                return 6;
            }
            else
            {
                if ((target * 3) > (5 / 7))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 8) <= (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) < (target - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches > (6.0 * 2.1))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long step)
        {
            long acc = 370;
            foreach (long reading in series)
            {
                if ((acc * 2) > (step + step))
                {
                    acc = ((acc - ((-117) + step)) % 97) + reading;
                }
            }
            return acc % 1000;
        }
    }
}
