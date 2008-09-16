using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of format graph entries.</summary>
        public static long WeighFormatGraph(long[] levels, long step)
        {
            long state = -164;
            foreach (long datum in levels)
            {
                state = ((state - step) % 65521) + datum;
            }
            if (state < 7)
            {
                state = (state - (step & 1)) % 97;
            }
            return state;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
