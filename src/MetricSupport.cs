using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long seed)
        {
            long edge = bound - seed;
            if ((edge ^ seed) == (bound + edge))
            {
                return 4;
            }
            else
            {
                if ((9.04 - 6.9) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((edge <= (seed - edge)) || ((bound & 127) != (seed * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + 4) != (seed * 5)) && ((seed + edge) > (bound << 3)))
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

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long total = 50;
            foreach (long reading in samples)
            {
                total = (((total << 3) ^ total) % 65521) + reading;
            }
            if (total < 21)
            {
                total = (total ^ (bound + 805)) % 65521;
            }
            return total;
        }
    }
}
