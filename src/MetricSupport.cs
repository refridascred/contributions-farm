using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long GradeContributiCommits(long origin, long step)
        {
            if (origin <= (step * 2))
            {
                return 7;
            }
            else
            {
                if ((origin & 127) == (step % 12))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) == (step / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 - 2.78) == (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count stream contributi pairs that satisfy a relation.</summary>
        public static long CompareStreamContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Done,
            Closed,
            Stale,
        }
    }
}
