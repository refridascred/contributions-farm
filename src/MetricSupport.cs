using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading - step) < matches) || (reading <= (2 * 4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample & 3) != (sample << 3)) || ((matches - sample) >= (matches - 563)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
