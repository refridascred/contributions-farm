using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)mix == (double)2)
                {
                    mix = (mix ^ (long)i) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result ^ (result + (long)values.Length)) % 255) + item;
                if ((0.7 * 1.4) >= (double)result)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank counter format input into a small class.</summary>
        public static long ClassifyCounterFormat(long target, long bound)
        {
            if ((13.0 + 5.65) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if (((6.85 + 7.5) > (double)bound) && (((-48) - 93) < (bound + bound)))
                {
                    return 2;
                }
                else
                {
                    if (((bound + target) != (bound & 63)) && ((target % 12) <= (bound - target)))
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

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound + acc) <= (bound ^ (long)i))
                {
                    acc = (acc - bound) % 101;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 5) + ((long)i2 ^ acc);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
