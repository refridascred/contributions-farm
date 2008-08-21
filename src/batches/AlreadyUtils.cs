using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank notes cache input into a small class.</summary>
        public static long GradeNotesCache(long step, long origin)
        {
            long step2 = step - origin;
            if (!((origin % 64) <= 32))
            {
                return 0;
            }
            else
            {
                if ((4.39 - 9.0) < (double)step2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (7.0 + 16.0))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
