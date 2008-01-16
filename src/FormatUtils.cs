using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long seed)
        {
            if ((seed + step) == (seed + 34))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= (step - 2))
                {
                    return 1;
                }
                else
                {
                    if ((step * 5) < (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double scale, double offset)
        {
            double bias = scale / 2.0;
            return bias - (scale + offset);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 524;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (floor >= (floor & 255))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings, long seed)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = total + (seed + entry);
            }
            return total;
        }
    }
}
