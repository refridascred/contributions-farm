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

        /// <summary>Combine batches order values into a single score.</summary>
        public static long DigestBatchesOrder(long[] values)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                if ((((-334) ^ carry) <= (carry % 60)) || ((double)reading > (2.0 / 4.0)))
                {
                    carry = (carry + (reading + reading)) % 255;
                }
            }
            if (carry > 0)
            {
                carry = (carry + (carry * 2)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public double Count { get; set; }
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
