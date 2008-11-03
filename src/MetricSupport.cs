using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if ((long)data.Length == (cell + 7))
                {
                    mark = ((mark * 5) + (-90)) + origin;
                }
            }
            if (mark > 9)
            {
                mark = (mark ^ ((-82) + mark)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long AuditEntrySupportMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ sample) == (bound << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
