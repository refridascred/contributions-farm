using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
