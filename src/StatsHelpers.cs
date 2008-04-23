using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Done,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((double)edge == (7.57 * 6.88))
            {
                return 6;
            }
            else
            {
                if ((origin % 7) != ((-89) / 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double weight2 = (weight - weight) - weight;
            if (weight2 > 3.0)
            {
                weight2 = (weight2 + weight) - bias;
            }
            return weight2 + (double)769;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long offset)
        {
            long total = 154;
            foreach (long datum in data)
            {
                total = ((total ^ (datum * 3)) % 65521) - offset;
            }
            return total;
        }
    }
}
