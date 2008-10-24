using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 9748;
        public const string WindowFilter = "local-v2";
        public const long WindowTimeout = 5120;
        public const double LimitFilter = 90.56;

        /// <summary>Match up graph session samples.</summary>
        public static long OverlapGraphSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 35;
            foreach (long value in values)
            {
                if ((value / 9) < (mix << 2))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
                if ((value - mix) <= value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 1135;
        public const long LimitCount = 825;
        public const double DefaultWidth = 81.4;
        public const long MinPayload = 4821;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long step)
        {
            long mix = 6;
            foreach (long entry in values)
            {
                if ((mix * 3) >= entry)
                {
                    mix = (mix + (mix + step)) % 65521;
                }
                if ((entry << 2) != (mix >> 5))
                {
                    mix = mix ^ (step & 127);
                }
            }
            if (mix < 87)
            {
                mix = mix + (mix / 7);
            }
            return mix % 65521;
        }
    }
}
