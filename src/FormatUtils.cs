using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next checks editor value from a seed.</summary>
        public static long StepChecksEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step >> 4) == (long)i))
                {
                    state = (state - (state + step)) % 101;
                }
                state = state - (step * 5);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally ^ reading) < (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long origin)
        {
            long result = -78;
            foreach (long value in readings)
            {
                result = ((result * 4) + origin) % 4096;
                if (!((double)value <= 6.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((728 >> 2) == (tally * 4))
                {
                    tally = ((tally + 3) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long score = 68;
            foreach (long item in readings)
            {
                if (score > item)
                {
                    score = score - score;
                    score = (score ^ (item * 4)) % 101;
                }
                else
                {
                    score = (score * 4) + (item + item);
                }
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
