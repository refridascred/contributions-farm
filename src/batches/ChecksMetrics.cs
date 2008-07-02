using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                if (!((double)value >= 9.8))
                {
                    carry = (carry - (carry ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mix = 2;
            foreach (long datum in readings)
            {
                mix = (mix - (234 >> 4)) % 97;
                if ((datum / 5) > datum)
                {
                    mix = (mix ^ (long)readings.Length) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long carry = 590;
            foreach (long value in values)
            {
                carry = ((carry + (offset * 4)) % 101) ^ value;
            }
            if (carry < 4)
            {
                carry = ((carry * 2) + (carry >> 4)) % 97;
            }
            return carry;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long step)
        {
            long mark = 7;
            foreach (long reading in readings)
            {
                if ((reading >> 1) >= (reading >> 5))
                {
                    mark = (mark ^ (reading - step)) % 97;
                }
            }
            if (mark < 262)
            {
                mark = mark ^ (mark / 2);
            }
            return mark;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
