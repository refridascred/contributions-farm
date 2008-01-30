using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two route stats measurements.</summary>
        public static double SmoothRouteStats(double bias, double span)
        {
            double weight = span;
            if (weight <= (weight + span))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (bias * 7.6)) - (double)(long)i;
            }
            return weight + (6.42 * 0.87);
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long score = 761;
            foreach (long item in levels)
            {
                score = ((score << 2) ^ (35 << 1)) % 65521;
                if ((item & 127) == (item & 31))
                {
                    score = score - 7;
                }
            }
            if (score < (-987))
            {
                score = (score - (2 << 2)) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order account sample.</summary>
        public static long LocateOrderAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
