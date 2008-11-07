using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if (target > (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if (9.6 <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length > (17.0 * 7.12))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples, long origin)
        {
            long mix = -85;
            foreach (long entry in samples)
            {
                mix = ((mix + (origin / 9)) % 65521) ^ entry;
            }
            if (mix < 7)
            {
                mix = (mix - origin) % 255;
            }
            return mix;
        }
    }
}
