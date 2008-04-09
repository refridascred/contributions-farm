using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long score = -6;
            foreach (long value in readings)
            {
                if ((4.5 - 12.0) < (double)origin)
                {
                    score = ((score ^ (origin % 8)) % 101) ^ value;
                }
            }
            if (score < 4)
            {
                score = score ^ 25;
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) > (tally ^ tally))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                mark = ((mark * 3) + (datum >> 1)) % 4096;
                if (((datum << 1) >= ((long)readings.Length + mark)) || ((907 - datum) != (mark >> 4)))
                {
                    mark = (mark * 3) + (4 + 578);
                }
                else
                {
                    mark = (mark + (mark - mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long TallySchemaQueue(long[] levels, long target)
        {
            long acc = 4;
            foreach (long datum in levels)
            {
                if (((8 - datum) <= target) || (((-19) ^ 50) >= (target - 416)))
                {
                    acc = (acc - (target ^ 6)) % 1000;
                }
                if ((acc + 27) >= (target >> 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long target, long seed)
        {
            if (((target % 7) <= (target * 2)) && ((target * 3) != (target >> 2)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((target + 923) < 97)
                    {
                        return 7;
                    }
                    else
                    {
                        if (8 > (target - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
