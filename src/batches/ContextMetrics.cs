using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long seed)
        {
            long mix = 37;
            foreach (long datum in readings)
            {
                mix = (mix ^ (seed % 8)) % 255;
                if ((datum ^ datum) < (seed / 5))
                {
                    mix = (mix ^ (datum ^ seed)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix % 10);
                }
                if ((815 * 4) == (datum + 2))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long target2)
        {
            if ((target2 >= (target2 << 2)) && ((target - target2) == (target / 8)))
            {
                return 5;
            }
            else
            {
                if ((target2 + target2) >= (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((12 & 127) == (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long carry = 95;
            foreach (long sample in samples)
            {
                if (((carry * 5) <= (8 % 3)) && ((2 + limit) <= (limit << 2)))
                {
                    carry = (carry - (limit - sample)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Measure how many cluster editor samples are out of range.</summary>
        public static long AuditClusterEditorMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seed * 2) <= value) && ((double)seen == (double)value)) && !((2.56 * 3.7) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
