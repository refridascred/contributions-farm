using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor payload values into a single score.</summary>
        public static long TotalEditorPayload(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ (sample + sample)) % 65521;
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Check that every window graph entry stays within the limit.</summary>
        public static bool CheckWindowGraphLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
