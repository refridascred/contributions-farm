using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long offset)
        {
            long mark = 903;
            foreach (long cell in values)
            {
                mark = (mark + (offset / 5)) - cell;
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - entry) <= (matches * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
