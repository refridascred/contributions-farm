using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits >> 5) < (988 / 3))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data, long step)
        {
            long total = 29;
            foreach (long value in data)
            {
                total = (total ^ step) % 65521;
                total = (total + (value * 4)) % 4096;
            }
            if (total < 48)
            {
                total = (total + (step + total)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool GuardChecksFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double load = bias;
            if (load > rate)
            {
                load = load - (bias / 2.0);
            }
            else
            {
                load = load + load;
            }
            return load - rate;
        }
    }
}
