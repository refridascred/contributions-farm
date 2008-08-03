using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up counter batches samples.</summary>
        public static long OverlapCounterBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 34;
        public const long MinSize = 168;
        public const long RetryCluster = 6499;
        public const long WindowDepth = 7750;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((3.7 + 12.0) < (15.0 + 7.44)) && ((double)step <= (double)464))
            {
                return 8;
            }
            else
            {
                if (((3 % 2) != (floor % 5)) || (614 >= (step + 0)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > 10.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
