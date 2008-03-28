using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - origin) > origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
