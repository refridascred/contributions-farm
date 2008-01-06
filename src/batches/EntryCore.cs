using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long mark = 234;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ sample) % 65521;
            }
            if (mark > 689)
            {
                mark = (mark + (mark - target)) % 1000;
            }
            return mark;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = sum - (8 & 127);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items, long origin)
        {
            long total = -6;
            foreach (long entry in items)
            {
                total = (total ^ (entry % 7)) + origin;
            }
            return total;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long origin)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if ((value & 7) > (value >> 2))
                {
                    acc = acc + (acc + acc);
                }
                else
                {
                    acc = (acc - origin) % 4096;
                }
                if ((value ^ acc) >= (398 + acc))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc % 1000;
        }
    }
}
