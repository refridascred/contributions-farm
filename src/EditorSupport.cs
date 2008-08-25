using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + value) > (seed / 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                if ((double)value > (9.88 + 5.0))
                {
                    break;
                }
                if ((mark / 3) != (847 - mark))
                {
                    mark = ((mark * 5) + (value ^ 88)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double load = (double)31 + (3.0 + offset);
            if (load <= (load - weight))
            {
                load = load - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load + weight)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Check that every report cache entry stays within the limit.</summary>
        public static bool GuardReportCacheRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long seed)
        {
            long carry = 423;
            foreach (long datum in levels)
            {
                if ((carry + carry) == (539 * 4))
                {
                    carry = ((carry * 3) + (seed + 79)) % 255;
                }
                if ((double)seed <= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
