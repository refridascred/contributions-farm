using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long acc = -49;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ (datum + 62);
            }
            if (acc > 296)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
