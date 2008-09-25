using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long score = -2;
            foreach (long sample in items)
            {
                if (((score - sample) != (sample ^ 8)) && ((28 + sample) >= score))
                {
                    score = (score + (sample - sample)) % 65521;
                }
            }
            if (score < 567)
            {
                score = score ^ ((-23) << 3);
            }
            return score;
        }
    }
}
