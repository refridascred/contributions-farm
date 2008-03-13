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

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
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
