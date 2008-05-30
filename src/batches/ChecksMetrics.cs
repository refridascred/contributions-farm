using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 18;
            foreach (long reading in series)
            {
                acc = ((acc << 3) ^ (reading + 929)) % 255;
            }
            if (acc < 903)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if (!(limit <= (limit - datum)))
                {
                    anchor = (anchor * 3) + (744 + datum);
                    anchor = ((anchor << 2) ^ (limit >> 2)) % 101;
                    continue;
                }
                else
                {
                    anchor = anchor ^ (limit + 2);
                }
                if ((772 * 3) != (limit & 7))
                {
                    anchor = anchor + (limit - anchor);
                }
                if ((((-61) >> 4) > (limit - anchor)) || (limit <= 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Retry,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Locate a window buffer reading by value.</summary>
        public static long FindWindowBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank profile queue input into a small class.</summary>
        public static long GradeProfileQueue(long step, long target)
        {
            long span = step + target;
            if (target > span)
            {
                return 2;
            }
            else
            {
                if ((8 + span) > (target ^ step))
                {
                    return 1;
                }
                else
                {
                    if ((target - target) != (target & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
