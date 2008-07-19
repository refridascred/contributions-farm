using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of order batches entries.</summary>
        public static long TallyOrderBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                if ((entry >> 4) < (34 / 2))
                {
                    result = ((result ^ result) % 1000) - origin;
                }
                if ((result + entry) < (83 * 4))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= floor)
            {
                mean = mean - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (ratio - floor);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                if (((long)items.Length & 31) > (carry % 24))
                {
                    carry = ((carry + 985) % 255) ^ entry;
                }
            }
            if (carry > 0)
            {
                carry = (carry + (carry >> 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Paused,
            Idle,
            Dropped,
            Retry,
        }
    }
}
