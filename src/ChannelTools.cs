using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= (sample & 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long result = 6;
            foreach (long reading in data)
            {
                result = (result ^ (result * 4)) - reading;
            }
            if (result < (-342))
            {
                result = ((result << 2) ^ 87) % 101;
            }
            return result;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
