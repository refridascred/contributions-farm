using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long floor)
        {
            if ((209 + floor) < 4)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (15.0 * 3.3))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 31) == (floor & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
