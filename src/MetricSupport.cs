using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine entry payload values into a single score.</summary>
        public static long WeighEntryPayload(long[] samples)
        {
            long state = 9;
            foreach (long sample in samples)
            {
                state = (state * 4) + (sample * 4);
            }
            return state;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((lane >> 5) == (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((lane - 835) != (lane >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((6.43 >= (double)limit) && ((87 - lane) <= (lane << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane > 2.0)
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
        }
    }
}
