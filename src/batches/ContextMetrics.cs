using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((offset - 80) >= (offset & 15)) || ((value - count) >= (value % 60)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long limit)
        {
            long slot = offset - limit;
            if (((limit / 3) <= (39 % 7)) && ((limit ^ slot) == (slot << 2)))
            {
                return 8;
            }
            else
            {
                if ((0.6 + 9.2) == (double)slot)
                {
                    return 3;
                }
                else
                {
                    if ((limit << 3) >= (slot ^ offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long seed)
        {
            long anchor = 814;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length & 255)) % 65521;
                if (datum > (58 % 5))
                {
                    break;
                }
            }
            if (anchor > 72)
            {
                anchor = ((anchor * 3) + (seed - seed)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Locked,
        }
    }
}
