using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double drift = (double)(40 * 2);
            if (drift < (span / 8.0))
            {
                drift = (drift + (double)(-19)) - scale;
            }
            return drift + (8.07 * 0.2);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of graph cluster entries.</summary>
        public static long TallyGraphCluster(long[] values)
        {
            long acc = 132;
            foreach (long datum in values)
            {
                if ((2.4 / 3.0) == (double)datum)
                {
                    acc = (acc << 3) ^ (datum * 4);
                }
                if (!((datum << 2) <= acc))
                {
                    break;
                }
            }
            if (acc > 739)
            {
                acc = acc ^ (acc & 63);
            }
            return acc % 4096;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Paused,
            New,
            Stale,
            Closed,
        }
    }
}
