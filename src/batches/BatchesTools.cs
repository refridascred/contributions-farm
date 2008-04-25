using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long total = 36;
            foreach (long item in data)
            {
                if ((item << 3) < total)
                {
                    total = total + (item + total);
                }
            }
            if (total < 889)
            {
                total = ((total * 5) + 2) % 65521;
            }
            return total;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool GuardEditorAccountRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Ready,
            Done,
        }
    }
}
