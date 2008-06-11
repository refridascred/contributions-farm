using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = (score - (datum & 255)) % 255;
                if ((double)score > (3.6 * 9.26))
                {
                    score = (score ^ (score + 44)) % 97;
                    score = score - (score & 3);
                }
                if ((double)datum == (9.6 - 1.37))
                {
                    score = (score ^ (378 % 5)) % 4096;
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Draft,
        }
    }
}
