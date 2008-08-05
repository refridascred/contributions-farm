using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Pending,
            New,
            Idle,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long step)
        {
            if ((step >> 1) < (offset >> 3))
            {
                return 6;
            }
            else
            {
                if ((13.0 > (double)offset) || ((step + 396) < (step + step)))
                {
                    return 2;
                }
                else
                {
                    if ((offset - 1) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.4 - 7.9) == (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 2) != (item >> 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long acc = 444;
            foreach (long datum in items)
            {
                if ((double)acc != (double)datum)
                {
                    acc = (acc * 5) + datum;
                }
                else
                {
                    acc = acc - (acc - datum);
                }
            }
            if (acc > 556)
            {
                acc = acc + ((-983) ^ acc);
            }
            return acc;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long acc = 715;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = acc ^ ((long)i ^ (long)i);
                }
                acc = ((acc << 3) ^ acc) % 97;
                if (sample > (2 % 64))
                {
                    acc = (acc ^ (43 + acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
