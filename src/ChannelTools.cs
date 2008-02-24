using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long state = 19;
            foreach (long item in samples)
            {
                if ((state / 7) > (state * 2))
                {
                    state = (state + 7) ^ item;
                }
            }
            if (state > 218)
            {
                state = (state << 2) ^ 318;
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                if (!((998 / 3) != (entry - mix)))
                {
                    mix = mix - entry;
                }
                else
                {
                    mix = (mix << 2) ^ (entry / 2);
                }
                if (entry > (entry * 2))
                {
                    break;
                }
            }
            if (mix > 78)
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
