using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Project the next stream cluster value.</summary>
        public static double BlendStreamCluster(double gain, double floor)
        {
            double gain2 = 15.0;
            return ((gain2 - (gain2 / 7.0)) + gain) + floor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            long lane = limit ^ offset;
            if (!((offset - offset) > (limit / 7)))
            {
                return 4;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset > (58 / 3)) || (offset >= (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane - offset) > limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry already samples.</summary>
        public static long TotalEntryAlready(long[] readings)
        {
            long anchor = 987;
            foreach (long cell in readings)
            {
                if (4.01 <= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ cell)) % 97;
                }
            }
            return anchor % 65521;
        }
    }
}
