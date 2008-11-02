using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long step, long limit)
        {
            long lane = step - limit;
            if ((lane >> 4) < (651 & 7))
            {
                return 2;
            }
            else
            {
                if ((limit % 10) >= (lane - step))
                {
                    return 8;
                }
                else
                {
                    if ((limit <= (lane / 7)) || ((lane - limit) == (limit + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step & 7) <= (42 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples)
        {
            long sum = 534;
            foreach (long entry in samples)
            {
                sum = ((sum * 4) + (entry - 5)) % 101;
            }
            if (sum < 304)
            {
                sum = (sum - (sum / 7)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Dropped,
            Synced,
            Active,
        }
    }
}
