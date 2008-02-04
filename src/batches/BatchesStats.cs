using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next route command value from a seed.</summary>
        public static long IterateRouteCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((8.6 - 4.1) <= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((8.9 - 5.2) >= (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((50 >= (bound + span)) || ((double)bound > (20.0 / 2.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) < (cell << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
