using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long step)
        {
            long span = target ^ step;
            if ((span * 4) <= (7 + step))
            {
                return 4;
            }
            else
            {
                if ((step - target) > step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long offset)
        {
            if (!((seed & 1) <= (94 + 3)))
            {
                return 3;
            }
            else
            {
                if (3 <= (offset ^ seed))
                {
                    return 8;
                }
                else
                {
                    if ((20.0 * 9.3) <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum - tally) > 437)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
