using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - 60) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long bound)
        {
            long lane = origin + bound;
            if (((lane - 202) > bound) || ((double)bound <= 20.0))
            {
                return 3;
            }
            else
            {
                if (((bound - 6) < (origin - origin)) && ((5.92 / 4.0) >= (double)lane))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 7) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((lane * 3) == (lane + 32)) || ((lane ^ lane) >= 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] readings, long step)
        {
            long acc = -892;
            foreach (long cell in readings)
            {
                acc = (((acc ^ (8 % 3)) % 4096) ^ cell) - step;
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
