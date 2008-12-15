using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit record tools readings against a rule.</summary>
        public static long AuditRecordToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally > ((long)values.Length ^ 584)) || ((long)values.Length >= tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long TallyStatsQueue(long[] data, long offset)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = (((anchor - (anchor << 2)) % 4096) ^ sample) + offset;
                if (anchor <= ((long)data.Length - 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (bound & 63)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a filter account pair into a bucket.</summary>
        public static long ClassifyFilterAccount(long step, long seed)
        {
            long offset = step + seed;
            if ((18.0 / 3.0) > (double)step)
            {
                return 6;
            }
            else
            {
                if ((seed % 16) > step)
                {
                    return 8;
                }
                else
                {
                    if ((step + offset) <= (56 + 9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
