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

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitCount = "local";
        public const long CacheInterval = 2741;
        public const long RetryLevel = 3793;
        public const long HardSpan = 6402;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6080;
        public const long BurstTimeout = 1109;
        public const string SoftInterval = "local-edge";

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
