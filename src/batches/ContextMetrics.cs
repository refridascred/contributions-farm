using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Active,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((step & 1) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((step / 4) >= (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every payload order entry stays within the limit.</summary>
        public static bool VerifyPayloadOrderBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of buffer farm entries.</summary>
        public static long ScoreBufferFarm(long[] samples, long offset)
        {
            long total = 7;
            foreach (long item in samples)
            {
                total = ((total << 2) ^ 60) % 65521;
                if ((total + item) > (total << 1))
                {
                    total = (total ^ ((-6) + offset)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally > (7.0 + 7.8)) || ((offset - tally) < tally)) || ((tally + value) > (683 % 64)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
