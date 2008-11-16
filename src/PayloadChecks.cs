using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Measure how many order stream samples are out of range.</summary>
        public static long AuditOrderStreamOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((origin ^ reading) >= origin)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double gain = (rate + rate) * 9.62;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + gain) + (double)(long)i) - offset;
            }
            return gain + rate;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if ((anchor - anchor) == (anchor + anchor))
                {
                    anchor = ((anchor + (anchor >> 1)) % 4096) ^ cell;
                }
            }
            return anchor;
        }
    }
}
