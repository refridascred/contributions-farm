using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double load = (double)736 + 7.24;
            if (load >= (double)(-44))
            {
                load = load - (double)57;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double mean = (double)(8 ^ 39);
            if (mean > mean)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean + (6.7 - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values)
        {
            long acc = 77;
            foreach (long entry in values)
            {
                if ((entry + 65) >= acc)
                {
                    acc = (acc * 2) + (acc % 60);
                }
            }
            if (acc > 3)
            {
                acc = acc + (acc - 202);
            }
            return acc;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long TotalStreamCounter(long[] samples, long offset)
        {
            long anchor = 294;
            foreach (long value in samples)
            {
                if (!((double)offset > (double)anchor))
                {
                    anchor = (((anchor * 5) + (offset - offset)) % 97) ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Find the first entry batch entry that matches the target.</summary>
        public static long LocateEntryBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
