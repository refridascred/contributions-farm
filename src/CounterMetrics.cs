using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long result = 2;
            foreach (long datum in series)
            {
                result = ((result ^ floor) % 4096) ^ datum;
                result = (result ^ (floor << 1)) % 255;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit + acc) == (limit + 516)) && (((long)i % 100) == (limit >> 3)))
                {
                    acc = (acc * 4) + (limit + (long)i);
                    acc = (acc ^ (limit + 7)) % 4096;
                }
                else
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of context record entries.</summary>
        public static long CombineContextRecord(long[] samples, long origin)
        {
            long mix = 235;
            foreach (long entry in samples)
            {
                if (mix < (origin % 24))
                {
                    mix = ((mix - (7 ^ 31)) % 97) + entry;
                }
            }
            return mix;
        }
    }
}
