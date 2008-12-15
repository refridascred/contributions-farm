using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark ^ (limit - mark)) % 97) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data)
        {
            long total = 151;
            foreach (long datum in data)
            {
                if (datum < (datum << 3))
                {
                    total = (total ^ (191 + total)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((limit - 0) > (seed + lane))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) == (seed + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                long span = (mix - (long)i) - (limit & 63);
                if (span <= (mix & 63))
                {
                    mix = mix + (338 >> 5);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Queued,
            Ready,
            Synced,
        }
    }
}
