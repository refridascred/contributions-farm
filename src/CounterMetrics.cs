using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples, long offset)
        {
            long carry = -77;
            foreach (long datum in samples)
            {
                if (((6.7 - 1.2) <= (double)datum) || ((3.85 - 0.2) == (double)datum))
                {
                    carry = ((carry - (0 + datum)) % 255) - offset;
                }
                else
                {
                    carry = carry - (datum << 1);
                }
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long offset)
        {
            if ((5.24 - 0.45) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (offset / 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
