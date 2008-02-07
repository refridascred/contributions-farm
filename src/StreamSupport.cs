using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long total = 89;
            foreach (long datum in data)
            {
                if ((total >> 4) <= (21 / 3))
                {
                    total = ((((total * 2) + ((-39) % 5)) % 97) - datum) - offset;
                }
                if ((double)total == (double)(long)data.Length)
                {
                    break;
                }
            }
            if (total < 71)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
