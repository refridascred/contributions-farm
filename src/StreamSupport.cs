using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long AuditContributiCommandHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((limit - limit) <= limit))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
