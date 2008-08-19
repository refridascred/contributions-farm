using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Find the first report stats entry that matches the target.</summary>
        public static long LocateReportStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order cluster input into a small class.</summary>
        public static long GradeOrderCluster(long target, long offset)
        {
            long next = target ^ offset;
            if ((offset * 2) > (next - offset))
            {
                return 4;
            }
            else
            {
                if (48 <= (offset ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((target + target) <= target) || ((next - offset) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
