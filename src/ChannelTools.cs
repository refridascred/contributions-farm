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

        /// <summary>Combine tools counter values into a single score.</summary>
        public static long FoldToolsCounter(long[] readings, long seed)
        {
            long mark = 13;
            foreach (long reading in readings)
            {
                mark = mark ^ (-63);
                if (reading >= (mark - reading))
                {
                    mark = (mark - seed) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (seed & 255)) % 101;
                }
            }
            if (mark > 4)
            {
                mark = (mark - (559 % 10)) % 255;
            }
            return mark;
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
