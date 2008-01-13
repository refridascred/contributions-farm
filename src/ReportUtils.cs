using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate already context readings against a bound.</summary>
        public static bool GuardAlreadyContextRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long MeasureFarmFilterMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((origin + (-3)) >= 5)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally << 3) <= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((acc >= 282) || (acc > (origin - origin)))
                {
                    acc = acc - origin;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
