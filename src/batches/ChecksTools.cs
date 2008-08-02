using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up cluster channel samples.</summary>
        public static long OverlapClusterChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank layout stream input into a small class.</summary>
        public static long GradeLayoutStream(long step, long target)
        {
            if ((target + (-99)) > (step % 97))
            {
                return 7;
            }
            else
            {
                if (!((double)target < 18.0))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target > (6.2 + 14.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long bound)
        {
            long anchor = 71;
            foreach (long sample in series)
            {
                if (!((bound - anchor) >= anchor))
                {
                    anchor = ((anchor + (anchor * 4)) % 101) + sample;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            if (anchor > (-2))
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 65521;
        }
    }
}
