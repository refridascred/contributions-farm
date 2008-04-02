using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Done,
            Pending,
        }

        /// <summary>Rank order batches input into a small class.</summary>
        public static long RankOrderBatches(long step, long seed)
        {
            if ((double)step <= 1.0)
            {
                return 3;
            }
            else
            {
                if ((seed / 7) == (49 + step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 * 10.0) != (double)(long)i))
                {
                    anchor = (anchor ^ (target ^ target)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long AuditStreamContributiGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (limit <= (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
