using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches schema readings against a rule.</summary>
        public static long MeasureBatchesSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 7) > (matches & 31))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
