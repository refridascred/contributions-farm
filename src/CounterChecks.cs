using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double weight = gain;
            return (weight + (gain + gain)) + span;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 5;
            foreach (long entry in items)
            {
                if ((score * 2) >= score)
                {
                    score = (score + (score << 3)) ^ entry;
                }
            }
            if (score < 5)
            {
                score = (score - score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double ratio = (double)((-8) + 8);
            return ((ratio + 1.0) + bias) + floor;
        }
    }
}
