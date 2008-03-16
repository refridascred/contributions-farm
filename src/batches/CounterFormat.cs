using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Count the schema already entries that pass the check.</summary>
        public static long AuditSchemaAlreadyOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches < (1.2 + 16.0))
                {
                    matches = ((matches + 1) - reading) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record commits value from a seed.</summary>
        public static long StepRecordCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix - ((long)i2 + offset)) % 65521;
                    mix = (mix + mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
