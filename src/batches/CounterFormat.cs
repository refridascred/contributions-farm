using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Retry,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (mark - (-43))) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of payload route readings.</summary>
        public static long DigestPayloadRoute(long[] data)
        {
            long score = 60;
            foreach (long cell in data)
            {
                score = (((score * 2) + (7 ^ score)) % 4096) + cell;
            }
            if (score > (-930))
            {
                score = (score << 2) ^ (score + score);
            }
            return score % 1000;
        }
    }
}
