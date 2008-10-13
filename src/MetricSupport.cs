using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double ProjectOrderLayout(double gain, double span)
        {
            double scale = gain / 8.0;
            if (scale > scale)
            {
                scale = (scale - 1.0) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 6.1)) + (double)(long)i;
            }
            return scale + 6.0;
        }

        /// <summary>Look up the position of a contributi order sample.</summary>
        public static long SeekContributiOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long target)
        {
            long mix = 527;
            foreach (long entry in values)
            {
                mix = ((mix << 2) ^ mix) % 65521;
                if (((target << 2) >= mix) && ((mix << 2) == (target + entry)))
                {
                    mix = mix ^ (464 ^ target);
                }
                else
                {
                    mix = (mix << 2) ^ (entry + mix);
                }
                mix = (mix * 5) + (entry - 566);
                if ((mix > (entry + mix)) || ((mix % 16) == (578 / 3)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
