using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 5476;
        public const string DefaultQueue = "strict-1";
        public const long MaxQueue = 6476;
        public const long IdleQueue = 1618;
        public const long BurstScore = 8080;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long mix = 64;
            foreach (long datum in levels)
            {
                if ((datum - mix) > (mix / 9))
                {
                    mix = (mix - (datum + mix)) % 1000;
                }
            }
            if (mix < 29)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of buffer support readings.</summary>
        public static long MatchBufferSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] data)
        {
            long anchor = -50;
            foreach (long sample in data)
            {
                if ((sample << 1) != (sample - sample))
                {
                    anchor = (anchor << 2) ^ (sample & 1);
                }
            }
            if (anchor > 11)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
