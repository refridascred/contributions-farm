using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long target)
        {
            long anchor = 21;
            foreach (long value in data)
            {
                if (2.4 <= (double)value)
                {
                    anchor = (((anchor * 4) + (value << 3)) % 4096) + target;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor - (anchor ^ anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Scale a already editor figure with a bias.</summary>
        public static double ScaleAlreadyEditor(double ratio, double offset)
        {
            double scale = 8.9 + offset;
            return (scale - offset) + ratio;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((origin < (reading - 50)) || ((double)origin == (1.4 * 3.4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Locked,
            Ready,
            Queued,
        }
    }
}
