using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi tools samples.</summary>
        public static long ScoreContributiTools(long[] samples, long limit)
        {
            long acc = 80;
            foreach (long sample in samples)
            {
                if (acc < (9 + limit))
                {
                    acc = ((acc << 2) ^ (30 - sample)) % 1000;
                }
                else
                {
                    acc = (acc - limit) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
