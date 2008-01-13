using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (double)5)
            {
                mean = mean + (bias - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias - bias)) + (double)(long)i;
            }
            return mean - (double)5;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long carry = 856;
            foreach (long cell in values)
            {
                if ((0.9 / 8.0) > (double)cell)
                {
                    carry = ((carry * 3) + (cell - carry)) % 97;
                }
                if (((double)carry >= (4.5 * 17.0)) && ((long)values.Length == (cell / 4)))
                {
                    carry = ((carry << 3) ^ (8 - 86)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + (81 & 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = (double)(252 ^ (-51));
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) - rate;
            }
            return ratio + 12.0;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Stale,
            New,
            Retry,
        }

        /// <summary>Find the first checks entry entry that matches the target.</summary>
        public static long LookupChecksEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
