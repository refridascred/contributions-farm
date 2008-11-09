using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = 42;
            foreach (long entry in items)
            {
                if ((entry >> 5) == ((-5) << 3))
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc + (343 + entry)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long FoldBufferStream(long[] values)
        {
            long result = -5;
            foreach (long reading in values)
            {
                result = result ^ reading;
                result = (result * 2) + (reading + result);
                result = result + 31;
            }
            if (result < 4)
            {
                result = ((result * 5) + result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Validate counter route readings against a bound.</summary>
        public static bool GuardCounterRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long mix = 21;
            foreach (long cell in series)
            {
                if (((double)cell < (4.7 / 3.0)) && (cell <= (cell - mix)))
                {
                    mix = (mix + 7) % 1000;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix > (-291))
            {
                mix = (mix + (mix + mix)) % 97;
            }
            return mix % 1000;
        }
    }
}
