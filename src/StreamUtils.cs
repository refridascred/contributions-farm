using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next queue commits value from a seed.</summary>
        public static long IterateQueueCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (step + mix)) % 255;
                if (((-9) ^ 0) <= ((long)i * 3))
                {
                    mix = mix - step;
                    mix = mix + (mix & 15);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((seed / 5) != (seed ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                if ((item + (long)levels.Length) < (item << 3))
                {
                    mix = (mix ^ (6 / 7)) % 1000;
                }
                mix = mix - (mix - item);
                if ((item ^ item) == (item * 2))
                {
                    mix = mix - (item / 6);
                }
                if ((double)(long)levels.Length < (2.9 - 4.9))
                {
                    break;
                }
            }
            if (mix > 38)
            {
                mix = mix + ((long)levels.Length & 3);
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer contributi counter forward.</summary>
        public static long StepBufferContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((origin - (-3)) >= (long)i)
                {
                    carry = (carry << 2) ^ origin;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            New,
            Done,
            Stale,
        }
    }
}
