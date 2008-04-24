using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches / 8) != (datum ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)step >= 3.8)
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
