using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long step)
        {
            long acc = 317;
            foreach (long reading in data)
            {
                acc = (((acc << 3) ^ (step << 3)) % 255) ^ reading;
            }
            if (acc < 190)
            {
                acc = acc - (step >> 2);
            }
            return acc % 97;
        }

        /// <summary>Count tools notes pairs that satisfy a relation.</summary>
        public static long CompareToolsNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
