using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Synced,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (offset * 3.5))
            {
                rate2 = rate2 - 3.59;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (double)11;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - 45) > (count * 2))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
