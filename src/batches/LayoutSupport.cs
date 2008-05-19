using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a channel commits reading.</summary>
        public static double ScaleChannelCommits(double scale, double bias)
        {
            double gain = (scale / 6.0) + (double)938;
            if (gain < (double)215)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)92) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 1) != (count >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record payload value.</summary>
        public static double BlendRecordPayload(double rate, double span)
        {
            double bias = (double)1 + span;
            return (bias + 3.59) + rate;
        }
    }
}
