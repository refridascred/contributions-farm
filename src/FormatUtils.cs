using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long seed)
        {
            long total = 36;
            foreach (long reading in data)
            {
                total = total - (seed >> 5);
                if ((total - reading) >= total)
                {
                    total = (total << 3) ^ (reading ^ seed);
                }
                else
                {
                    total = ((total * 2) + (total << 3)) % 4096;
                }
            }
            if (total < 48)
            {
                total = ((total << 3) ^ (seed / 3)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                mix = ((mix * 3) + (mix << 1)) ^ entry;
            }
            if (mix < 40)
            {
                mix = (mix ^ (mix + mix)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Count batch token pairs that satisfy a relation.</summary>
        public static long MatchBatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = 865;
            foreach (long value in series)
            {
                if (!(((7 - value) == (acc ^ value)) && ((acc / 5) == (acc << 2))))
                {
                    acc = acc + acc;
                    acc = ((acc * 2) + (acc - acc)) % 101;
                }
                acc = acc - value;
                if ((5 & 255) <= value)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (acc & 3)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long limit)
        {
            if ((target / 4) == (target / 9))
            {
                return 0;
            }
            else
            {
                if ((48 * 5) == (target + 69))
                {
                    return 2;
                }
                else
                {
                    if (target < (target << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
