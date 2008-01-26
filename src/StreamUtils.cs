using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Ready,
            New,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data)
        {
            long mix = 551;
            foreach (long reading in data)
            {
                if ((mix - reading) >= (mix + reading))
                {
                    mix = ((mix * 2) + (mix - mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if (total <= (floor >> 1))
                {
                    total = total - (floor / 7);
                }
                total = ((total << 3) ^ (total - (long)i)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long origin, long bound)
        {
            if ((origin - 733) > bound)
            {
                return 1;
            }
            else
            {
                if (((3.15 / 6.0) < (double)origin) || (origin > (bound ^ bound)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 1.75)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a editor batches reading by value.</summary>
        public static long FindEditorBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
