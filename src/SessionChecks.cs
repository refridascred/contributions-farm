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

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

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

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double drift = (double)(222 ^ 41);
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + (3.5 * 3.6)) + (double)(long)i) + bias) + offset;
            }
            return drift + (drift * 6.35);
        }
    }
}
