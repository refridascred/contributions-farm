using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up commits token samples.</summary>
        public static long MatchCommitsTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Draft,
            Synced,
        }
    }
}
