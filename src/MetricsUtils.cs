using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long offset)
        {
            long lane = target - offset;
            if ((target > (offset % 2)) || ((offset >> 2) <= 0))
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (11.0 + 9.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > (lane / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + 7.0) - floor;
            }
            return load + (load * 4.87);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long FoldEntryCache(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (offset >= (offset & 31))
                {
                    anchor = (((anchor * 5) + (17 + offset)) % 101) - sample;
                }
                else
                {
                    anchor = (anchor << 3) ^ (36 - 28);
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor - (offset % 64)) ^ (long)i;
                }
                anchor = (anchor - 252) % 65521;
                if ((anchor ^ anchor) >= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
