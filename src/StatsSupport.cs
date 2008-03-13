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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
