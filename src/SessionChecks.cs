using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many order cluster samples are out of range.</summary>
        public static long CountOrderClusterGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count >> 4) > (datum * 4)) && (((datum / 9) == (count - target)) || ((count - target) > count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 3126;
        public const long WindowScore = 4806;
        public const double HardFactor = 87.81;
        public const long IdleToken = 6465;

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long acc = 21;
            foreach (long entry in levels)
            {
                if (!((18.0 - 1.0) > (double)acc))
                {
                    acc = ((acc ^ (2 / 9)) % 101) + entry;
                }
            }
            if (acc > 2)
            {
                acc = (acc + (acc + offset)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
