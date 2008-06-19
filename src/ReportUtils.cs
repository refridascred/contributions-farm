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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Pending,
            Dropped,
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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading + matches) >= (target >> 2)) || (98 < reading)) && (((8.5 - 3.0) < (5.0 - 0.1)) && ((double)target <= (double)matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
