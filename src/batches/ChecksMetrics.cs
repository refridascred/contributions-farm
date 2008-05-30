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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples, long offset)
        {
            long anchor = 665;
            foreach (long value in samples)
            {
                anchor = ((anchor + 36) + value) + offset;
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series)
        {
            long mark = 773;
            foreach (long value in series)
            {
                if ((value - mark) > (mark + mark))
                {
                    mark = mark ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (value - value);
                }
            }
            if (mark > 2)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
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
