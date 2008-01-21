using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the buffer tools entries that pass the check.</summary>
        public static long CountBufferToolsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((double)datum != (double)42) || (datum > seed)) && !((seed << 2) != (seed - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long result = 576;
            foreach (long reading in items)
            {
                if ((8.25 / 6.0) <= (double)reading)
                {
                    result = result ^ 34;
                }
                if ((3.2 / 2.0) >= (double)reading)
                {
                    break;
                }
            }
            if (result > (-662))
            {
                result = (result ^ (result ^ result)) % 101;
            }
            return result;
        }
    }
}
