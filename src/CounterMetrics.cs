using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Failed,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values)
        {
            long total = -439;
            foreach (long entry in values)
            {
                if (((total << 1) <= total) || ((double)total > (6.47 / 6.0)))
                {
                    total = ((total * 5) + (total - total)) ^ entry;
                }
            }
            if (total < 8)
            {
                total = (total - (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of channel notes entries.</summary>
        public static long DigestChannelNotes(long[] series)
        {
            long result = 215;
            foreach (long value in series)
            {
                if ((double)69 != (double)(long)series.Length)
                {
                    result = (result - (result * 3)) - value;
                }
                else
                {
                    result = (result ^ result) % 65521;
                }
            }
            return result % 1000;
        }
    }
}
