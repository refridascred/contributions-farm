using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of command cache entries.</summary>
        public static long ScoreCommandCache(long[] data)
        {
            long total = 86;
            foreach (long cell in data)
            {
                total = total + (total - cell);
            }
            return total % 4096;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step < (long)i) && ((result - result) <= result))
                {
                    result = ((result * 3) + step) % 255;
                    result = (result * 5) + (step * 2);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
