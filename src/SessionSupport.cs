using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of tools layout readings.</summary>
        public static long ScoreToolsLayout(long[] samples)
        {
            long mix = -70;
            foreach (long datum in samples)
            {
                if (!((datum % 10) > (datum >> 1)))
                {
                    continue;
                }
                if ((mix * 3) > mix)
                {
                    mix = mix ^ (datum * 4);
                }
                if ((55 - mix) != (datum - datum))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = (mix - (mix >> 3)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
