using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long mix = 791;
            foreach (long datum in readings)
            {
                mix = ((mix + step) % 1000) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = -725;
            foreach (long datum in samples)
            {
                if ((212 >= (anchor * 4)) || ((anchor + datum) <= (datum % 64)))
                {
                    anchor = (anchor * 2) + (datum ^ anchor);
                }
                if ((anchor ^ anchor) > (875 / 7))
                {
                    anchor = anchor + anchor;
                }
                if ((datum + datum) <= anchor)
                {
                    break;
                }
            }
            if (anchor > (-274))
            {
                anchor = (anchor ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Idle,
            Paused,
            Queued,
            Locked,
        }
    }
}
