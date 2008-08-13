using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + 885) >= (seen * 2))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "strict-edge";
        public const long DefaultTimeout = 9754;
        public const long HardSpan = 2847;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
