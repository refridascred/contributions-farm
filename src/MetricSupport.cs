using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items, long step)
        {
            long anchor = 35;
            foreach (long sample in items)
            {
                anchor = ((anchor ^ (anchor + anchor)) % 97) + sample;
                if ((double)anchor >= 4.11)
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ step) % 255;
            }
            return anchor;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 75;
            foreach (long item in series)
            {
                carry = ((carry - 81) % 97) ^ item;
                carry = (carry - (4 / 7)) % 4096;
            }
            if (carry < 2)
            {
                carry = (carry + ((long)series.Length - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) >= ((long)data.Length + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
