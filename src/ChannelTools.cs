using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a report batch value against two limits.</summary>
        public static long GradeReportBatch(long seed, long seed2)
        {
            if ((seed >> 2) < seed)
            {
                return 0;
            }
            else
            {
                if (seed <= (seed << 3))
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 2) > (seed2 ^ seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed2 << 1) == (seed >> 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) <= (count - sample))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Failed,
            Active,
        }
    }
}
