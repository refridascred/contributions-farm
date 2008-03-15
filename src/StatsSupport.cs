using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long origin)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if (((origin ^ item) >= 82) && ((item ^ anchor) <= (anchor & 63)))
                {
                    anchor = ((anchor * 5) + (long)samples.Length) % 101;
                    continue;
                }
                else
                {
                    anchor = anchor - (origin + origin);
                }
                anchor = (anchor ^ (40 + 622)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long acc = 32;
            foreach (long entry in items)
            {
                acc = ((acc * 3) + acc) + entry;
                acc = (acc * 2) + (acc & 7);
            }
            if (acc < (-360))
            {
                acc = (acc * 2) + (4 + acc);
            }
            return acc;
        }
    }
}
