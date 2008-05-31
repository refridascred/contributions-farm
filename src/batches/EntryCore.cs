using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double drift = (5.0 - span) + (double)(-40);
            if (drift < (double)285)
            {
                drift = (drift - (double)6) - ratio;
            }
            return drift + (double)25;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long origin)
        {
            long offset = step + origin;
            if (((origin * 5) >= (offset ^ offset)) && ((double)origin <= (8.6 + 3.0)))
            {
                return 0;
            }
            else
            {
                if ((318 - offset) > (step / 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool GuardCounterPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
