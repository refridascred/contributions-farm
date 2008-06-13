using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data)
        {
            long mark = 815;
            foreach (long value in data)
            {
                if (value > (mark - mark))
                {
                    mark = mark + value;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3 + matches) > (matches * 5))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
