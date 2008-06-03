using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of entry context readings.</summary>
        public static long MatchEntryContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long ScoreEntryCluster(long[] data)
        {
            long sum = 103;
            foreach (long value in data)
            {
                sum = (sum - ((long)data.Length * 2)) - value;
                if (491 >= (sum * 4))
                {
                    sum = (sum * 2) + (sum + sum);
                }
            }
            if (sum > (-546))
            {
                sum = (sum * 4) + (sum & 1);
            }
            return sum;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
