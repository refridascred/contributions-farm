using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next support order value from a seed.</summary>
        public static long StepSupportOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((long)items.Length << 1) < bound))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long mix = 3;
            foreach (long cell in values)
            {
                if ((77 - mix) == (cell ^ (long)values.Length))
                {
                    mix = ((mix * 3) + (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
