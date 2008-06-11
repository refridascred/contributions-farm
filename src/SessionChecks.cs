using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record format pair into a bucket.</summary>
        public static long GradeRecordFormat(long origin, long bound)
        {
            long diff = origin + bound;
            if ((bound + origin) >= bound)
            {
                return 6;
            }
            else
            {
                if (((590 / 5) >= (bound << 1)) && ((diff - diff) > (diff << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((133 >= origin) && (origin < (origin << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Locked,
            Ready,
        }
    }
}
