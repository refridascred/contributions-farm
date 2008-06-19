using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a payload commits value against two limits.</summary>
        public static long BucketPayloadCommits(long step, long offset)
        {
            if ((double)step == (5.4 + 6.0))
            {
                return 3;
            }
            else
            {
                if (!(step <= (offset & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset > 4.6)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long CombineStatsStream(long[] samples)
        {
            long state = 69;
            foreach (long sample in samples)
            {
                if (!((double)sample > 19.0))
                {
                    state = (state << 3) ^ ((long)samples.Length * 2);
                }
                if (((sample * 4) > (state + 0)) || (state >= (state % 5)))
                {
                    break;
                }
            }
            if (state > 61)
            {
                state = ((state * 4) + 888) % 1000;
            }
            return state;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ bound;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = acc ^ ((-7) + limit);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Dropped,
            Stale,
            Retry,
        }
    }
}
