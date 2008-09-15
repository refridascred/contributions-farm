using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor context entry stays within the limit.</summary>
        public static bool ValidateEditorContextRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen - (long)data.Length) <= (reading << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
