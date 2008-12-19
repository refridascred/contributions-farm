using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                long slot = (score ^ score) - (long)i;
                score = (score - ((long)i * 4)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 3) + slot) % 4096) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Done,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((long)readings.Length >= limit))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
