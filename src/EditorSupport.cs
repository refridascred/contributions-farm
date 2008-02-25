using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((22 + offset) >= (long)i)
                {
                    acc = (acc * 2) + (long)i;
                }
                else
                {
                    acc = ((acc * 3) + (offset & 63)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long SeriesWindowBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total + total;
                if (!((total - (long)i) == ((long)i + offset)))
                {
                    total = total - (50 % 24);
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
