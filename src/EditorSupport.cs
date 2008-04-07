using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Paused,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Locked,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long target2)
        {
            if ((target2 - target2) > (target - target2))
            {
                return 6;
            }
            else
            {
                if (!((target2 + target2) > (target + target2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values, long target)
        {
            long sum = 36;
            foreach (long cell in values)
            {
                sum = sum ^ (sum - 24);
                if (((cell & 1) > (target + cell)) || (9.43 >= (double)sum))
                {
                    sum = (sum * 5) + (sum * 5);
                }
            }
            return sum % 97;
        }
    }
}
