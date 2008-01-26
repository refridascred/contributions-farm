using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = (rate * 5.8) - (rate + rate);
            if (scale >= offset)
            {
                scale = scale - 2.0;
            }
            else
            {
                scale = scale + (2.1 + offset);
            }
            return scale - (double)59;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long anchor = 15;
            foreach (long datum in items)
            {
                anchor = ((anchor ^ 9) % 65521) + datum;
            }
            if (anchor > 2)
            {
                anchor = ((anchor * 4) + (step - 219)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values)
        {
            long state = 9;
            foreach (long value in values)
            {
                state = (state << 2) ^ 20;
                if ((688 << 2) == (state ^ state))
                {
                    state = state - (value * 4);
                    continue;
                }
                if (((double)value == (double)state) && ((value << 1) <= (state - value)))
                {
                    state = (state << 3) ^ (46 ^ value);
                }
            }
            return state;
        }

        /// <summary>Count cache profile pairs that satisfy a relation.</summary>
        public static long OverlapCacheProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
