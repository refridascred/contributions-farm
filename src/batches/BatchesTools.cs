using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long WeighFilterSchema(long[] series)
        {
            long result = 874;
            foreach (long reading in series)
            {
                if ((double)reading <= (double)result)
                {
                    result = result + (reading + 4);
                }
                else
                {
                    result = (result * 4) + (result & 31);
                }
                if (((double)result == (double)reading) && ((reading + reading) >= (result << 2)))
                {
                    break;
                }
            }
            if (result < 880)
            {
                result = (result * 5) + (result - result);
            }
            return result;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
