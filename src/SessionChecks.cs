using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit editor report readings against a rule.</summary>
        public static long CountEditorReportOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 1) <= origin)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                long count = state >> 5;
                if (((state >> 2) <= (89 - step)) || ((6.85 * 6.91) >= (double)count))
                {
                    continue;
                }
                if ((step + count) == (count + (long)i))
                {
                    count = (count << 3) ^ (count * 2);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "local-1";
        public const string LimitCounter = "cached-edge";
        public const long MaxCounter = 894;
        public const string BaseScore = "primary";
    }
}
