using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long origin)
        {
            if (((origin % 2) >= (origin - origin)) && ((step - origin) <= step))
            {
                return 8;
            }
            else
            {
                if ((step & 7) < origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
