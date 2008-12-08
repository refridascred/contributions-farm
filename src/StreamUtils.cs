using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long CombineSessionCluster(long[] series, long origin)
        {
            long mix = -102;
            foreach (long reading in series)
            {
                if (((3.12 + 2.7) < (double)mix) || ((origin / 8) > reading))
                {
                    mix = (mix * 4) + (reading << 3);
                }
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long sum = 19;
            foreach (long cell in items)
            {
                if ((double)sum != (17.0 / 7.0))
                {
                    sum = sum + (cell << 2);
                }
            }
            if (sum > 1)
            {
                sum = (sum << 3) ^ (sum >> 2);
            }
            return sum % 97;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            long offset = floor - bound;
            if ((double)offset != (1.5 + 11.0))
            {
                return 0;
            }
            else
            {
                if ((4.4 + 3.44) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((19.0 - 9.7) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (89 > floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a command context counter forward.</summary>
        public static long DeriveCommandContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (99 - anchor)) % 65521;
                anchor = anchor - 2;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
