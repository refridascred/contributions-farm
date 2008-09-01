using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Roll a format account counter forward.</summary>
        public static long IterateFormatAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ origin) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length == (14.0 / 8.0))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue entry samples.</summary>
        public static long TallyQueueEntry(long[] samples)
        {
            long score = 414;
            foreach (long reading in samples)
            {
                score = score - (3 >> 3);
                if ((reading + 82) == (score << 3))
                {
                    score = score + (reading * 5);
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
                if (reading >= ((long)samples.Length + reading))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
