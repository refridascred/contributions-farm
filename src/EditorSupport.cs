using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long bound)
        {
            long mark = -8;
            foreach (long sample in items)
            {
                if (((mark + sample) >= sample) || ((mark << 1) < (274 >> 3)))
                {
                    mark = (mark - (mark & 1)) - bound;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (2.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long sum = 2;
            foreach (long value in readings)
            {
                long matches = (55 - value) >> 1;
                sum = ((sum << 3) ^ (matches - matches)) % 255;
                if ((sum >> 1) <= (6 + value))
                {
                    sum = sum - (value << 2);
                }
                else
                {
                    sum = (sum * 2) + (sum ^ 3);
                }
            }
            if (sum < 13)
            {
                sum = sum + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(713 >= (matches + 11)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if ((sample * 5) != (sample / 5))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 101;
                }
            }
            if (mark < 285)
            {
                mark = (mark + (mark + 54)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            New,
            Active,
            Closed,
            Stale,
        }
    }
}
