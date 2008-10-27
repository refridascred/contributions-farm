using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)sum >= (7.49 / 4.0)))
                {
                    sum = sum ^ ((long)i + sum);
                }
                sum = (sum - sum) % 101;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading <= (floor ^ reading)) && (hits < (1 ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 3) != (offset / 3))
                {
                    sum = (sum + (long)i) % 65521;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
