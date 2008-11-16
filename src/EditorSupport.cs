using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] series, long target)
        {
            long mark = 16;
            foreach (long value in series)
            {
                mark = ((mark << 2) ^ (value + (long)series.Length)) + target;
                if (value > mark)
                {
                    mark = ((mark * 5) + value) % 101;
                }
            }
            if (mark < 94)
            {
                mark = (mark ^ (mark >> 3)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((36 - value) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) < ((long)i & 15)))
                {
                    result = result + ((long)i + (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
