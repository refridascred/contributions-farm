using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long acc = 788;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc * 2) + offset) % 101) ^ (long)i;
                }
                acc = (acc * 3) + (value * 4);
            }
            if (acc > (-6))
            {
                acc = acc ^ (offset << 1);
            }
            return acc;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long bound, long limit)
        {
            if (!((double)limit <= (5.0 / 8.0)))
            {
                return 2;
            }
            else
            {
                if ((284 - limit) <= (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if ((bound - limit) <= (2 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
