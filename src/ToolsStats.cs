using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((8.0 * 3.21) >= (double)item) || (item >= (17 / 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowWidth = 5875;
        public const long MinCommits = 489;
        public const string HardFactor = "strict-1";

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long seed)
        {
            if ((floor + floor) != (floor ^ 1))
            {
                return 1;
            }
            else
            {
                if (!((double)floor == (3.4 - 3.15)))
                {
                    return 7;
                }
                else
                {
                    if ((2.6 - 0.87) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6 << 3) > seed) || (floor > (floor ^ seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((1.0 + 1.0) != (double)datum) && ((datum + datum) > 70))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)246)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + (gain * 4.64);
            }
            return gain2 - gain2;
        }
    }
}
