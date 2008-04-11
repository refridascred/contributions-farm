using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((double)5 < (3.0 * 1.0))
            {
                return 3;
            }
            else
            {
                if ((cur << 2) <= (cur + cur))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset != (1.6 * 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur << 3) == (offset2 + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already layout samples.</summary>
        public static long FoldAlreadyLayout(long[] data)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ sum) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Failed,
            Closed,
            New,
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long AuditQueueWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (sample & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            if ((18.0 - 1.9) < (double)limit)
            {
                return 7;
            }
            else
            {
                if (((limit - limit) >= (origin * 4)) && (origin > (limit - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (9.63 - 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 3) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
