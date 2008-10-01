using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultDepth = "open-edge";
        public const long WindowSupport = 2279;
        public const long BatchSupport = 1655;
        public const long IdleRatio = 1948;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long acc = 75;
            foreach (long value in values)
            {
                if ((value << 2) > (value - 670))
                {
                    acc = (acc + value) % 4096;
                }
            }
            if (acc < (-4))
            {
                acc = (acc - (origin + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (7.4 <= (double)hits)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
