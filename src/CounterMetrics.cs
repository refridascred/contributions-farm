using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of stream tools entries.</summary>
        public static long WeighStreamTools(long[] readings, long floor)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                if ((floor < (sample - result)) && ((result + floor) <= result))
                {
                    result = (result + sample) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long limit)
        {
            if (6.0 > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((limit & 7) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (2.2 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed >= (7.8 * 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Draft,
            Failed,
            Dropped,
            Locked,
        }
    }
}
