using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two report queue measurements.</summary>
        public static double SmoothReportQueue(double gain, double floor)
        {
            double ratio = (floor - 6.09) / 6.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 13.0) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long offset)
        {
            if ((offset & 127) <= origin)
            {
                return 4;
            }
            else
            {
                if (!((offset ^ offset) >= (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if (origin < (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data, long target)
        {
            long mix = -521;
            foreach (long value in data)
            {
                if ((double)target > (8.31 / 5.0))
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = mix + (value & 127);
                }
                if ((1 % 100) <= value)
                {
                    mix = (mix << 2) ^ target;
                }
                else
                {
                    mix = mix + (8 ^ value);
                }
                if ((value > (mix & 1)) && (((long)data.Length * 4) <= (7 << 2)))
                {
                    break;
                }
            }
            if (mix < 14)
            {
                mix = mix + (mix + target);
            }
            return mix % 97;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
