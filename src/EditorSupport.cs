using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mark = 2;
            foreach (long reading in samples)
            {
                if ((double)reading < (7.0 - 7.6))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
            }
            if (mark < 67)
            {
                mark = (mark + (mark % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if ((mix + 477) > (mix - mix))
                {
                    mix = (mix ^ (mix % 97)) + sample;
                }
                else
                {
                    mix = ((mix << 3) ^ ((-106) / 7)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long carry = -6;
            foreach (long sample in data)
            {
                carry = (carry ^ carry) ^ sample;
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Closed,
            Synced,
        }
    }
}
