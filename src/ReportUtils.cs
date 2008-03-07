using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((long)series.Length < offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ (acc ^ acc);
                acc = ((acc << 2) ^ (bound % 16)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double load = span;
            if (load > 1.1)
            {
                load = load + load;
            }
            else
            {
                load = load + (span / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (bias + 7.0)) + (double)(long)i;
            }
            return load + (load / 2.0);
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long step)
        {
            if (step < (step >> 5))
            {
                return 4;
            }
            else
            {
                if ((step + 74) > (step & 127))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Dropped,
            Ready,
            Queued,
            Done,
        }
    }
}
