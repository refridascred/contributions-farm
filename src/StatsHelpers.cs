using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (9 < value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                long delta = state >> 3;
                if (((double)state != (15.0 * 0.95)) && ((state << 3) <= delta))
                {
                    state = (state * 3) + ((long)i << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
