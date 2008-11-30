using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 < (seed << 2))
            {
                return 6;
            }
            else
            {
                if ((10.0 / 8.0) == (double)seed2)
                {
                    return 4;
                }
                else
                {
                    if (((double)seed2 != (double)step) || ((4.6 - 8.5) <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed2 >= (seed2 * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
