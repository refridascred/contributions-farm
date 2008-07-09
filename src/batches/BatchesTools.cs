using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 7) <= (entry / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm format pair into a bucket.</summary>
        public static long ClassifyFarmFormat(long seed, long target)
        {
            long lane = seed + target;
            if ((2.54 / 4.0) >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((8.4 + 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)lane == (20.0 + 1.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + lane) == (lane / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
