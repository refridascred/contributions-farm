using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long floor2)
        {
            if (((floor2 - floor2) <= (floor2 + 53)) || (576 <= (floor + floor2)))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) != (floor2 + floor2))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor == (9.6 * 1.89)) && (floor2 <= (floor2 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor % 2) <= floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((-554) >= (6 - reading))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report payload readings.</summary>
        public static long OverlapReportPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
