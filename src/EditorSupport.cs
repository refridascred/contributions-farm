using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + target) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values)
        {
            long acc = 114;
            foreach (long sample in values)
            {
                acc = acc + sample;
                acc = acc ^ acc;
                if (!((1.8 * 5.9) <= (double)sample))
                {
                    acc = (acc * 4) + (sample ^ acc);
                }
                else
                {
                    acc = ((acc * 4) + (sample + 29)) % 97;
                }
            }
            if (acc > (-30))
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long mark = 696;
            foreach (long cell in values)
            {
                if (mark < (mark ^ mark))
                {
                    mark = ((mark + (mark % 3)) % 1000) - cell;
                }
            }
            return mark;
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool VerifyMetricsStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
