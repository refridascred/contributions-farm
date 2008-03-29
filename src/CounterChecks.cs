using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 627;
        public const long BurstOrder = 6140;
        public const double BaseScore = 59.14;
        public const long SoftTimeout = 668;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Rank editor metrics input into a small class.</summary>
        public static long GradeEditorMetrics(long step, long floor)
        {
            if ((step / 9) > step)
            {
                return 2;
            }
            else
            {
                if ((floor % 2) >= step)
                {
                    return 1;
                }
                else
                {
                    if (floor <= (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long limit)
        {
            long gap = target - limit;
            if ((limit % 60) < gap)
            {
                return 5;
            }
            else
            {
                if (!(gap <= (42 - target)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
