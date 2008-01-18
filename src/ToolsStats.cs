using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = (mix + (mix % 12)) ^ cell;
                if ((mix + mix) < 822)
                {
                    mix = (mix << 2) ^ (3 >> 3);
                }
                else
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 97;
                }
            }
            if (mix > 0)
            {
                mix = mix - (210 - mix);
            }
            return mix % 97;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i ^ result) < (seed + result))
                {
                    result = result + (618 / 6);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long offset)
        {
            long score = 2;
            foreach (long entry in levels)
            {
                if (!((offset + entry) <= (offset & 1)))
                {
                    score = (score - (entry % 60)) % 255;
                }
                if ((offset >> 3) < (offset + offset))
                {
                    score = (score + ((-69) / 8)) % 97;
                }
            }
            if (score < 913)
            {
                score = (score << 2) ^ (score - score);
            }
            return score;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Locked,
            Ready,
            Done,
            Stale,
        }
    }
}
