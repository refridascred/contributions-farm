using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) > ((long)values.Length / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            if (!((28 + limit) >= (step + step)))
            {
                return 5;
            }
            else
            {
                if ((limit * 4) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (15.0 * 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step == (15.0 * 7.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
