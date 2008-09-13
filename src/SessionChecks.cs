using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long SeriesRecordQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound / 2) > (score ^ score))
                {
                    score = (score ^ (-3)) % 1000;
                    score = (score - (score >> 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
