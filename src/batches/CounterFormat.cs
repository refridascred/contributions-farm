using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metrics buffer entries.</summary>
        public static long CombineMetricsBuffer(long[] readings, long step)
        {
            long mark = 374;
            foreach (long reading in readings)
            {
                if (!((mark ^ mark) != (840 << 2)))
                {
                    mark = (mark + (step / 5)) % 4096;
                    continue;
                }
                else
                {
                    mark = (mark * 4) + (mark / 8);
                }
                mark = mark + ((long)readings.Length + reading);
                if (((reading / 9) >= reading) && (step <= 291))
                {
                    break;
                }
            }
            if (mark < 645)
            {
                mark = (mark * 5) + (step % 8);
            }
            return mark;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Synced,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Active,
            Queued,
            Stale,
            Done,
        }
    }
}
