using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double load = (offset / 6.0) * 2.0;
            if (load > ratio)
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Dropped,
            Ready,
            Done,
            New,
        }
    }
}
