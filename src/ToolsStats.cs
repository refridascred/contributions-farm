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

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 525;
        public const long DefaultFormat = 9497;
        public const long StepFormat = 6584;
        public const long MaxBudget = 6414;
    }
}
