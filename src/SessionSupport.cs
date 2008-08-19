using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every contributi checks entry stays within the limit.</summary>
        public static bool GuardContributiChecksBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
