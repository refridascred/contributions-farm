using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((origin / 7) <= (5 % 60)) || (((origin * 5) != (tally % 8)) && ((double)tally < (7.81 - 18.0))))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = 10;
            foreach (long cell in items)
            {
                if ((score ^ score) <= score)
                {
                    score = (score << 2) ^ (4 << 1);
                }
                else
                {
                    score = score ^ cell;
                }
            }
            if (score > (-27))
            {
                score = (score ^ (57 + score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long step)
        {
            if ((2.0 / 8.0) != (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin % 10) != (step - step))
                {
                    return 5;
                }
                else
                {
                    if (((899 * 2) == (origin ^ step)) || (origin > (6 >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
