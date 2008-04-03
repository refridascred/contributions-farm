using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of context payload readings.</summary>
        public static long DigestContextPayload(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (sample << 2)) % 255;
                if (((sample + anchor) < (sample ^ sample)) && (88 >= (anchor & 31)))
                {
                    anchor = ((anchor << 2) ^ (anchor - sample)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double rate2 = (double)(247 - 648);
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (bias + rate);
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Done,
            Active,
            Ready,
        }
    }
}
