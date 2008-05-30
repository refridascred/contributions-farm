using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account batches entry that matches the target.</summary>
        public static long FindAccountBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long step2)
        {
            long diff = step ^ step2;
            if (((diff & 15) > (step + diff)) || ((step2 * 2) >= (diff << 3)))
            {
                return 7;
            }
            else
            {
                if ((diff & 15) <= step)
                {
                    return 0;
                }
                else
                {
                    if (!(step2 < step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 < (step2 >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
