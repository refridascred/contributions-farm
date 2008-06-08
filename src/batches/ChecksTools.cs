using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((713 > ((long)values.Length << 2)) || ((78 ^ 6) < reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((double)2 == (double)origin) && (total < (total - total)))
                {
                    total = (total ^ total) % 65521;
                    total = total ^ origin;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double weight = (floor + floor) * 6.2;
            if (weight < floor)
            {
                weight = weight + (bias / 9.0);
            }
            else
            {
                weight = weight + (floor - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = -816;
            foreach (long datum in series)
            {
                score = score - (datum + score);
                score = ((score * 4) + (score % 64)) % 255;
                score = score ^ ((long)series.Length << 2);
            }
            if (score > 8)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }
    }
}
