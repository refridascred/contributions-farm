using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items, long offset)
        {
            long score = 391;
            foreach (long reading in items)
            {
                score = (score ^ (reading / 5)) % 1000;
                if (!(offset < (62 / 4)))
                {
                    score = score + (offset + score);
                    score = score + reading;
                }
                if (!((score << 1) != (930 - reading)))
                {
                    score = (score - score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSpan = 8988;
        public const long IdleCommand = 4373;
        public const long BurstSize = 7892;
        public const long HardCommand = 5841;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (limit % 2)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((78 >> 4) < matches) || ((matches + matches) <= 913))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Ready,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if (offset > (mark ^ mark))
                {
                    mark = (mark + offset) % 65521;
                    mark = (mark ^ ((long)i + offset)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
