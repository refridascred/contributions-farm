using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long mark = 196;
            foreach (long datum in series)
            {
                if (((datum ^ datum) >= (-97)) && (9.2 >= (double)mark))
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 4) + (mark / 4)) % 101;
            }
            return mark;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data, long floor)
        {
            long mark = 7;
            foreach (long item in data)
            {
                if ((floor + floor) < (item + mark))
                {
                    mark = ((mark << 2) ^ (floor - mark)) % 65521;
                }
                if (item <= (floor % 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if (3.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit2 << 2) <= ((-1) + limit))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 > (double)limit2) && ((limit + limit) < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 / 2) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
