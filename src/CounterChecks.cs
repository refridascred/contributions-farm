using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Done,
            Pending,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long bound)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                total = (total - (bound + 78)) % 101;
                if ((total >> 1) >= bound)
                {
                    total = total - (cell + cell);
                }
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = -486;
            foreach (long sample in readings)
            {
                if (((sum / 9) > sum) && (sum >= (sample + sample)))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum > (-7))
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a layout batches sample.</summary>
        public static long LookupLayoutBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
