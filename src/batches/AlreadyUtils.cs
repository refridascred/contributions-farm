using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - (8 - (long)i)) % 255;
                if ((seed % 60) <= ((long)i ^ 7))
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 1000;
                    acc = acc + (seed ^ seed);
                }
                else
                {
                    acc = ((acc * 3) + (seed << 1)) % 255;
                    acc = (acc * 5) + (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Active,
            Paused,
        }
    }
}
