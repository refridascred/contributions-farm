using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every layout commits entry stays within the limit.</summary>
        public static bool CheckLayoutCommitsRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit account report readings against a rule.</summary>
        public static long AuditAccountReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum >= (datum % 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Pending,
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
