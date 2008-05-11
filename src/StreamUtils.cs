using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6255;
        public const long LimitWidth = 8883;
        public const long StepSpan = 3555;
        public const double StepToken = 25.58;

        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long PairEditorCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - (total & 7)) % 1000) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate support cache readings against a bound.</summary>
        public static bool GuardSupportCacheLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
