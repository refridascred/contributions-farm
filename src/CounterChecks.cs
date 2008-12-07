using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings)
        {
            long carry = 118;
            foreach (long sample in readings)
            {
                if ((carry * 2) < sample)
                {
                    carry = carry ^ (sample + carry);
                }
                else
                {
                    carry = ((carry * 4) + (long)readings.Length) % 101;
                }
            }
            if (carry > 122)
            {
                carry = (carry + (16 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long MeasureLayoutWindowMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((634 / 5) >= (target - matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long CompareStatsBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long mark = 216;
            foreach (long reading in levels)
            {
                mark = (((mark * 2) + (mark % 97)) ^ reading) - origin;
            }
            return mark % 4096;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 489;
            foreach (long value in samples)
            {
                if ((460 + value) > (value >> 4))
                {
                    total = total + (65 * 5);
                    total = (total - (long)samples.Length) % 4096;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
                total = (total * 3) + (value & 1);
                if ((total <= value) && ((total + (long)samples.Length) >= (value * 5)))
                {
                    total = (total << 2) ^ (total + (long)samples.Length);
                }
                else
                {
                    total = (total ^ (total * 5)) % 255;
                }
            }
            return total % 65521;
        }
    }
}
