using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Derive the next report support value from a seed.</summary>
        public static long SeriesReportSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor ^ anchor) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long origin)
        {
            long result = 58;
            foreach (long datum in readings)
            {
                if ((datum * 5) > (result & 3))
                {
                    result = (result << 2) ^ (origin / 8);
                }
            }
            if (result > 7)
            {
                result = (result + origin) % 101;
            }
            return result;
        }
    }
}
