using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series, long limit)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = sum + reading;
                if ((sum / 5) != (sum - sum))
                {
                    sum = sum + (sum >> 5);
                }
                else
                {
                    sum = (sum * 3) + (limit / 2);
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long bound)
        {
            if ((double)limit != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((9.0 + 4.73) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit >= (4.2 - 7.8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (9 + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command commits samples are out of range.</summary>
        public static long TallyCommandCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count != (0.02 * 3.25))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
