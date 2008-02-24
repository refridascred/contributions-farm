using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 535;
            foreach (long cell in levels)
            {
                if (((mark & 3) >= (mark * 2)) || ((cell - 578) > cell))
                {
                    mark = (mark + (cell * 5)) % 101;
                }
                else
                {
                    mark = (mark + (496 >> 4)) % 65521;
                }
            }
            if (mark > 227)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            if ((target >> 1) <= (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target ^ 193) > (step >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double span)
        {
            double gain = rate;
            if (gain < gain)
            {
                gain = gain + (span / 6.0);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(-29)) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
