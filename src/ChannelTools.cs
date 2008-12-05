using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long TallyChannelProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Audit already context readings against a rule.</summary>
        public static long MeasureAlreadyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (9.5 / 3.0)) || (7 >= (7 + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
