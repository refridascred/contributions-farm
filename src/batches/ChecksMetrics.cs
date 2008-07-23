using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry * 3) <= 1)
                {
                    result = (result << 3) ^ (entry >> 4);
                }
                if ((entry + result) >= entry)
                {
                    result = (result - (result & 3)) % 255;
                }
                else
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Roll a tools payload counter forward.</summary>
        public static long StepToolsPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - ((long)i & 127);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 350;
            foreach (long sample in data)
            {
                if (((result - sample) == (943 * 5)) || (result < (sample - sample)))
                {
                    result = (result - (968 + sample)) % 255;
                }
                result = result - (sample - sample);
            }
            return result % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long acc = 820;
            foreach (long cell in items)
            {
                if (((double)cell > (16.0 - 4.0)) || ((acc + 1) == (acc ^ acc)))
                {
                    acc = (acc - (acc - 124)) % 65521;
                }
            }
            if (acc > 2)
            {
                acc = (acc << 2) ^ (long)items.Length;
            }
            return acc % 4096;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry < (85 + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
