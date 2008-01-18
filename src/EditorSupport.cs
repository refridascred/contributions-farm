using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long target)
        {
            long total = -94;
            foreach (long value in data)
            {
                total = (total ^ 0) - target;
                if ((85 + total) < (30 + 205))
                {
                    total = total ^ 619;
                }
                else
                {
                    total = ((total * 2) + (value + value)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long origin)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((((acc * 2) + acc) % 97) ^ (long)i) - origin;
                }
                acc = acc + (reading >> 4);
            }
            return acc;
        }

        /// <summary>Digest a series of metrics route entries.</summary>
        public static long DigestMetricsRoute(long[] readings, long origin)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if (((state & 3) >= (state - cell)) && ((double)origin == (2.6 / 4.0)))
                {
                    state = ((state << 2) ^ (50 % 7)) % 255;
                }
            }
            if (state < (-4))
            {
                state = (state + 578) % 65521;
            }
            return state;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
