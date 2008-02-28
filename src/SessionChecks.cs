using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks window counter forward.</summary>
        public static long IterateChecksWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target << 1);
                acc = ((acc * 3) + target) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 3126;
        public const long WindowScore = 4806;
        public const double HardFactor = 87.81;
        public const long IdleToken = 6465;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long mark = 31;
            foreach (long datum in series)
            {
                mark = (mark - (mark >> 2)) % 4096;
                if (datum >= 191)
                {
                    mark = (mark << 2) ^ (94 % 3);
                }
                else
                {
                    mark = (mark - datum) % 4096;
                }
            }
            return mark;
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
