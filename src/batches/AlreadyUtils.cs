using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((result >> 3) >= (step + step)))
                {
                    result = (result + (step >> 4)) % 65521;
                    result = (result + ((long)i % 3)) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((5.09 * 1.18) == (double)bound)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total - ((long)i - total)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if (((mix - value) < (value / 3)) && ((double)value >= (double)mix))
                {
                    mix = mix + (mix << 1);
                }
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
