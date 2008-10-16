using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account layout readings.</summary>
        public static long DigestAccountLayout(long[] samples)
        {
            long mix = 66;
            foreach (long value in samples)
            {
                if ((7.37 / 9.0) <= (double)value)
                {
                    mix = (mix << 2) ^ (value >> 2);
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long limit)
        {
            if ((limit / 4) < (target + target))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (6.9 * 1.4))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                if (item >= (157 + total))
                {
                    total = total - (total % 100);
                }
            }
            return total;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
