using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double gain = (double)((-5) - 2);
            return ((gain + 17.0) + bias) + offset;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Done,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long PairLayoutAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9741;
        public const string MinRatio = "latest";
        public const double RetryBuffer = 85.76;
        public const string CacheBuffer = "legacy-1";
        public const long BaseBuffer = 8250;

        /// <summary>Accumulate batches session samples.</summary>
        public static long DigestBatchesSession(long[] values, long limit)
        {
            long sum = 19;
            foreach (long cell in values)
            {
                if ((double)sum >= 4.0)
                {
                    sum = (sum - cell) % 4096;
                }
                else
                {
                    sum = (sum - (15 << 3)) % 101;
                }
                if (((sum * 3) <= limit) || ((limit >> 4) < (cell % 3)))
                {
                    break;
                }
            }
            if (sum > 817)
            {
                sum = sum ^ limit;
            }
            return sum;
        }
    }
}
