using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up layout record samples.</summary>
        public static long OverlapLayoutRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            if (((-7) - target) != (target & 7))
            {
                return 1;
            }
            else
            {
                if ((step * 2) < (step ^ step))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (double)step)
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

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double weight = floor / 4.0;
            if (weight > floor)
            {
                weight = weight - (floor + weight);
            }
            else
            {
                weight = weight + scale;
            }
            return weight - (scale + weight);
        }

        /// <summary>Count the graph githubfarm entries that pass the check.</summary>
        public static long AuditGraphGithubfarmGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally + target) >= target) || ((target & 127) <= tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits tools pair into a bucket.</summary>
        public static long ClassifyCommitsTools(long offset, long step)
        {
            if ((double)step < (4.8 / 6.0))
            {
                return 1;
            }
            else
            {
                if ((offset * 2) < (offset / 3))
                {
                    return 5;
                }
                else
                {
                    if ((step >= (step / 6)) && (offset < (offset / 2)))
                    {
                        return 0;
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
