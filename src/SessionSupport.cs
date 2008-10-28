using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cache stats values into a single score.</summary>
        public static long CombineCacheStats(long[] values)
        {
            long mark = -3;
            foreach (long datum in values)
            {
                mark = (mark - (datum & 31)) % 65521;
                if ((double)2 > (double)mark)
                {
                    break;
                }
                if ((mark * 2) > datum)
                {
                    mark = ((mark * 5) + (datum % 97)) % 4096;
                }
                if ((78 >> 4) >= mark)
                {
                    break;
                }
            }
            if (mark < 688)
            {
                mark = (mark - (mark & 63)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "local-edge";
        public const long CacheFactor = 7477;
        public const string LimitScore = "latest-v2";
        public const long RetryBudget = 280;
    }
}
