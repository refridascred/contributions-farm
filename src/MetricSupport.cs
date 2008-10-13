using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count <= 9.0))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
