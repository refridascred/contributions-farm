using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (mark + 86)) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
