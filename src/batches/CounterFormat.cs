using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 88;
            foreach (long datum in data)
            {
                if ((datum < mix) || (8.2 >= (double)mix))
                {
                    mix = (mix - (datum >> 4)) % 65521;
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long anchor = 72;
            foreach (long cell in series)
            {
                if (cell > (anchor + offset))
                {
                    anchor = (anchor + 411) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + offset;
                }
            }
            if (anchor < 162)
            {
                anchor = ((anchor << 2) ^ offset) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long AuditSessionBufferMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seed << 3) != (seen + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
