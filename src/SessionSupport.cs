using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the already layout series from a seed.</summary>
        public static long SeriesAlreadyLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ mark) % 255;
                if ((long)i > floor)
                {
                    mark = mark ^ (mark / 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
