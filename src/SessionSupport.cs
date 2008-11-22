using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of layout schema entries.</summary>
        public static long WeighLayoutSchema(long[] data)
        {
            long anchor = 926;
            foreach (long value in data)
            {
                if (!((double)value < (3.0 + 7.7)))
                {
                    anchor = anchor + value;
                }
                if (value <= (anchor ^ anchor))
                {
                    anchor = (anchor ^ (anchor + value)) % 4096;
                }
                if ((value + value) < value)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) % 101;
                }
            }
            if (anchor > 40)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((seen * 2) >= (reading - reading)) && ((2.1 + 10.0) == (double)seen)) || ((1.0 / 3.0) == (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
