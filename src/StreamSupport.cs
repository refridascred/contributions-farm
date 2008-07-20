using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] levels, long seed)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                if (((reading >> 1) > 1) || ((595 >> 4) < (anchor << 2)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                if ((anchor - 30) < (reading - (-42)))
                {
                    anchor = ((anchor << 3) ^ seed) % 255;
                    continue;
                }
                else
                {
                    anchor = (anchor ^ (seed << 2)) % 4096;
                }
                if (((seed << 3) <= 778) && (anchor >= (reading << 1)))
                {
                    anchor = ((anchor * 5) + (seed % 8)) % 101;
                }
                else
                {
                    anchor = anchor ^ (seed % 64);
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor - seed) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of editor account readings.</summary>
        public static long TallyEditorAccount(long[] items, long bound)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = (sum + (sum + 66)) - entry;
            }
            if (sum < 4)
            {
                sum = ((sum * 5) + (bound & 127)) % 255;
            }
            return sum % 65521;
        }
    }
}
