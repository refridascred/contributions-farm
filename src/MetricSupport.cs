using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long result = 625;
            foreach (long datum in data)
            {
                if (((datum % 64) == (datum & 7)) || ((result & 15) >= (bound ^ datum)))
                {
                    result = ((result << 3) ^ (bound * 4)) % 255;
                }
            }
            if (result > 431)
            {
                result = result - 0;
            }
            return result % 97;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Active,
            Done,
            Queued,
            New,
        }
    }
}
