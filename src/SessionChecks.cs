using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long step)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                if ((3.4 / 7.0) > (double)mix)
                {
                    mix = (mix ^ (mix ^ entry)) + step;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultSize = 2.06;
        public const double MaxChecks = 63.62;
        public const long WindowBudget = 9228;
        public const string WindowDepth = "stable-v2";
        public const long RetryTimeout = 5249;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long step)
        {
            long mix = 427;
            foreach (long entry in items)
            {
                if ((step ^ entry) < (entry + entry))
                {
                    mix = (mix + (mix % 100)) % 1000;
                }
            }
            if (mix > 586)
            {
                mix = (mix * 5) + (step + mix);
            }
            return mix % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
