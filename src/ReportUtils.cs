using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5516;
        public const double HardBudget = 86.56;
        public const long LimitFilter = 4101;
        public const string DefaultFilter = "strict-1";

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long mark = 3;
            foreach (long item in items)
            {
                mark = (mark - (mark * 4)) % 65521;
                if (((double)mark >= (13.0 + 2.0)) && ((mark - mark) < (target << 2)))
                {
                    mark = ((mark * 5) + item) % 255;
                }
                else
                {
                    mark = (mark - (item + (long)items.Length)) % 4096;
                }
            }
            if (mark > 733)
            {
                mark = (mark + 73) % 65521;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4253;
        public const double SoftNotes = 67.94;
        public const long StepInterval = 2624;
        public const string BaseScore = "open";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Done,
            Draft,
            Dropped,
            Stale,
        }
    }
}
