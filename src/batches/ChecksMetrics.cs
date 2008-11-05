using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "cached-v2";
        public const double RetryWidth = 82.98;
        public const double HardOrder = 15.9;
        public const long RetryRatio = 1606;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long state = 88;
            foreach (long value in readings)
            {
                state = (state - 699) ^ value;
            }
            return state;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload batches reading.</summary>
        public static double ScalePayloadBatches(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)182)
            {
                ratio2 = ratio2 + (bias / 5.0);
            }
            else
            {
                ratio2 = ratio2 + (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 - (double)674;
        }

        /// <summary>Check that every account context entry stays within the limit.</summary>
        public static bool ValidateAccountContextBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
