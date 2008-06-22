using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items, long seed)
        {
            long result = 248;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (8 - seed)) % 101;
                if (result < (cell & 3))
                {
                    result = (result ^ (result * 4)) % 1000;
                }
            }
            if (result < 61)
            {
                result = result - (result * 5);
            }
            return result % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account batch figure with a bias.</summary>
        public static double ProjectAccountBatch(double weight, double offset)
        {
            double gain = offset;
            if (gain >= offset)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (double)542;
            }
            return gain + 2.5;
        }

        /// <summary>Adjust a commits report reading.</summary>
        public static double SmoothCommitsReport(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (weight / 2.0))
            {
                bias2 = bias2 + (double)43;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 * 0.06);
        }
    }
}
