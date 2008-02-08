using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long ClassifyProfileCluster(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (266 < (offset2 + offset2))
            {
                return 6;
            }
            else
            {
                if (((offset + offset2) <= (offset2 - span)) || (26 >= (span + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((6 > (offset2 * 5)) || ((offset >> 5) >= span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.7 + 2.0) <= (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i << 1) >= (sum >> 3)) || (((long)i % 100) <= (sum & 15)))
                {
                    sum = ((sum * 5) + (bound - sum)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
