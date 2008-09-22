using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double ProjectFarmFormat(double ratio, double span)
        {
            double gain = ratio / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - gain) - (double)(long)i) - span;
            }
            return gain + 1.0;
        }

        /// <summary>Derive the next counter record value from a seed.</summary>
        public static long RollCounterRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                long tally = ((long)i >> 2) ^ origin;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 5) + (tally + tally)) % 65521) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
