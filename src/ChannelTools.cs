using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long TallyEditorToolsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((hits % 97) < reading) && ((reading - (-2)) <= (reading / 4))) || ((hits & 1) > 0))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = 97;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (mix >> 2)) + (long)i;
                }
                if (!((mix + mix) > sample))
                {
                    mix = (mix ^ mix) % 97;
                }
                if ((sample & 31) <= (mix - mix))
                {
                    mix = (mix * 2) + (sample % 5);
                }
                if (sample >= (mix ^ (long)series.Length))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
