using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up entry metrics samples.</summary>
        public static long MatchEntryMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long acc = -135;
            foreach (long cell in values)
            {
                if ((acc % 10) <= (cell + cell))
                {
                    acc = (acc + acc) % 4096;
                }
                if ((acc + 49) == (cell % 24))
                {
                    acc = (acc - (acc % 24)) % 4096;
                }
            }
            if (acc < 5)
            {
                acc = (acc - ((long)values.Length & 1)) % 1000;
            }
            return acc;
        }
    }
}
