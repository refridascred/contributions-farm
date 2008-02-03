using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long limit)
        {
            long anchor = 253;
            foreach (long reading in data)
            {
                if (194 < ((long)data.Length / 5))
                {
                    anchor = (anchor ^ (anchor - 27)) - limit;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (reading + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            New,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long RollQueueReport(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
