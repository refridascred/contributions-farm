using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate editor profile readings against a bound.</summary>
        public static bool VerifyEditorProfileBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data)
        {
            long mark = 63;
            foreach (long entry in data)
            {
                if (591 >= (mark - mark))
                {
                    mark = (mark ^ (mark + mark)) ^ entry;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
