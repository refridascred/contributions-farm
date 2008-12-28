using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "cached-v2";
        public const long BasePayload = 3459;
        public const long LimitInterval = 3403;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values, long step)
        {
            long mix = 867;
            foreach (long datum in values)
            {
                if ((mix - mix) >= (datum % 3))
                {
                    mix = ((mix + (406 ^ datum)) % 4096) + step;
                }
            }
            if (mix > 3)
            {
                mix = (mix << 2) ^ (29 >> 4);
            }
            return mix % 1000;
        }
    }
}
