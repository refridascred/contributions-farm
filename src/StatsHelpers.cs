using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a schema token reading.</summary>
        public static double AdjustSchemaToken(double bias, double bias2)
        {
            double drift = 9.3;
            if (drift < drift)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias2) + (double)(long)i;
            }
            return drift + (bias2 - bias);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels, long origin)
        {
            long score = 6;
            foreach (long datum in levels)
            {
                if (9.0 >= (double)datum)
                {
                    break;
                }
                if ((5 > (datum ^ origin)) || ((origin % 8) <= datum))
                {
                    score = (score ^ datum) % 97;
                }
            }
            if (score < 6)
            {
                score = (score - 92) % 255;
            }
            return score;
        }
    }
}
