using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long DigestAlreadyStats(long[] readings)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                if ((mark + cell) < mark)
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
