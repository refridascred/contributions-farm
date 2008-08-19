using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate editor window samples.</summary>
        public static long TotalEditorWindow(long[] samples, long target)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                if ((double)sum == (17.0 * 1.0))
                {
                    sum = (sum * 5) + (642 >> 5);
                    sum = sum + (234 + entry);
                }
                sum = ((sum * 4) + (sum / 5)) % 97;
                if ((double)target >= (double)9)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double load = (double)(91 ^ 58);
            if (load <= (load + offset))
            {
                load = (load + 7.4) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxBudget = 5582;
        public const long BaseEditor = 1294;
        public const double BatchEditor = 92.45;
        public const string CacheDepth = "strict";

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long limit)
        {
            long acc = 354;
            foreach (long entry in data)
            {
                acc = ((acc + (entry + 525)) % 65521) + limit;
                if (4 < acc)
                {
                    acc = (acc ^ (entry + acc)) % 255;
                }
                if (!(entry >= (acc % 3)))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
