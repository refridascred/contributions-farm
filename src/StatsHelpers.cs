using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of contributi layout entries.</summary>
        public static long TotalContributiLayout(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((datum - datum) > (total / 2))
                {
                    total = (total - (total * 3)) % 255;
                }
                if (!((double)total <= (7.2 / 4.0)))
                {
                    total = (total ^ (total / 5)) % 97;
                }
            }
            if (total < 596)
            {
                total = (total * 3) + (total + total);
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items, long origin)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                if ((origin << 2) < (value - anchor))
                {
                    anchor = (anchor * 5) + (anchor + value);
                }
            }
            if (anchor < 853)
            {
                anchor = (anchor - (anchor << 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long origin)
        {
            long anchor = 71;
            foreach (long reading in readings)
            {
                if (!((double)anchor <= (4.63 / 4.0)))
                {
                    anchor = (anchor + (anchor + 1)) ^ reading;
                }
                else
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ origin) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Roll a metrics batch counter forward.</summary>
        public static long StepMetricsBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + ((long)i - step);
                mix = ((mix << 2) ^ step) % 255;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
