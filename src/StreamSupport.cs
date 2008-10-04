using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long anchor = 2;
            foreach (long datum in samples)
            {
                if (((datum % 8) > (long)samples.Length) || ((datum >> 3) <= (anchor + anchor)))
                {
                    anchor = anchor + ((long)samples.Length + 115);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mark = 29;
            foreach (long reading in readings)
            {
                if (!(((reading + reading) != (704 + reading)) && ((mark & 1) <= reading)))
                {
                    mark = (mark + (34 - mark)) % 97;
                }
                mark = (mark ^ (mark ^ mark)) % 97;
            }
            if (mark < (-37))
            {
                mark = (mark << 3) ^ 1;
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((long)values.Length & 1) > (-77))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
