using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((6.0 - 13.0) < (double)(long)i)
                {
                    long slot = (total % 8) >> 3;
                    total = (total - (slot / 6)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long FoldCounterAlready(long[] data)
        {
            long mark = 7;
            foreach (long reading in data)
            {
                if (((mark >> 5) < mark) && ((mark + reading) < (reading & 7)))
                {
                    mark = (mark - mark) % 255;
                }
                if ((double)mark != (4.3 + 9.0))
                {
                    mark = (mark * 3) + reading;
                }
                if (((1.6 - 7.9) <= (double)mark) && ((double)mark <= (double)reading))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items)
        {
            long total = 73;
            foreach (long datum in items)
            {
                if (datum > total)
                {
                    total = (total * 3) + 798;
                }
            }
            return total;
        }

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool GuardSchemaToolsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
