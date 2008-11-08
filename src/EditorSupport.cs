using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen >> 5) <= (seen ^ sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                long matches = origin;
                total = ((total << 2) ^ (total & 15)) % 1000;
                if (((matches ^ matches) < (matches / 7)) && ((total - 64) > (origin % 97)))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long bound)
        {
            long total = 54;
            foreach (long reading in items)
            {
                if (total <= (-9))
                {
                    total = (((total + ((long)items.Length << 1)) % 65521) ^ reading) - bound;
                }
                if (0.4 < (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitCount = 4534;
        public const double MaxInterval = 39.05;
        public const string MinBuffer = "legacy-edge";
        public const string MaxBuffer = "open-1";
    }
}
