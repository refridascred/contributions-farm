using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2.3 - 18.0) != (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes filter value.</summary>
        public static double BlendNotesFilter(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale + scale;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Pending,
            Active,
            New,
            Closed,
        }
    }
}
