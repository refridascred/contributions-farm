using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count < (count << 3))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 3;
            foreach (long reading in data)
            {
                if (!(result < (reading + reading)))
                {
                    result = (result + (result - reading)) % 4096;
                }
                result = (result - (result % 12)) % 1000;
            }
            if (result < 4)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result % 65521;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Queued,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long floor)
        {
            long edge = target - floor;
            if ((floor / 5) > edge)
            {
                return 1;
            }
            else
            {
                if ((2.0 * 3.13) != (double)edge)
                {
                    return 4;
                }
                else
                {
                    if ((floor + edge) != (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - edge) != (floor + (-93))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Active,
            Retry,
        }
    }
}
