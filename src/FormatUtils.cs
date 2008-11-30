using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally >= (datum + tally))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long step)
        {
            long next = target ^ step;
            if ((target + target) >= (881 & 3))
            {
                return 5;
            }
            else
            {
                if (((target - step) < (next / 8)) && ((target << 2) > next))
                {
                    return 2;
                }
                else
                {
                    if ((target + (-13)) == (step % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)162 > (double)next)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((12.0 / 6.0) > (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel record readings.</summary>
        public static long WeighChannelRecord(long[] data, long offset)
        {
            long result = 653;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result - entry) % 101) - (long)i;
                }
                if (!((offset + entry) >= (offset / 8)))
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
