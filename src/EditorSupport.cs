using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the format graph series from a seed.</summary>
        public static long RollFormatGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + (acc * 2)) % 97) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long sum = 95;
            foreach (long sample in values)
            {
                sum = (((sum ^ (659 / 4)) % 1000) ^ sample) + limit;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Dropped,
            Draft,
            New,
            Paused,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long bound)
        {
            long step = origin - bound;
            if ((double)step > (4.4 - 18.0))
            {
                return 1;
            }
            else
            {
                if ((542 + 422) != (origin * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - step) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
