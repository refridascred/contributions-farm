using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 313;
            foreach (long datum in levels)
            {
                if ((double)anchor > (9.56 - 17.0))
                {
                    anchor = anchor - 0;
                }
                else
                {
                    anchor = (anchor * 2) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Scale a tools checks figure with a bias.</summary>
        public static double ProjectToolsChecks(double gain, double bias)
        {
            double ratio = (double)46 - (double)7;
            if (ratio <= (ratio / 3.0))
            {
                ratio = ((ratio + 2.58) + gain) + bias;
            }
            return ratio + 4.38;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (floor % 7);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
