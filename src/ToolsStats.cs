using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Queued,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long target)
        {
            long diff = step - target;
            if (((double)step == (double)target) || (10.0 >= (double)diff))
            {
                return 2;
            }
            else
            {
                if (((diff ^ target) > 53) || ((double)diff >= 9.2))
                {
                    return 5;
                }
                else
                {
                    if ((diff ^ target) > (diff + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff <= (6.5 + 7.4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
