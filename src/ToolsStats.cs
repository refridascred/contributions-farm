using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter record measurements.</summary>
        public static double BlendFilterRecord(double bias, double span)
        {
            double load = (span - bias) * 5.51;
            if (load > 4.8)
            {
                load = load - (8.06 + bias);
            }
            else
            {
                load = load + span;
            }
            return load + bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Rank format checks input into a small class.</summary>
        public static long SortFormatChecks(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step / 8) >= bound) && ((double)offset < (8.44 / 3.0)))
            {
                return 4;
            }
            else
            {
                if (bound > (bound * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = rate2 - span;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (span + 4.0)) + (double)(long)i;
            }
            return rate2 - 9.18;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale - (double)1;
            }
            return scale + (scale + span);
        }
    }
}
