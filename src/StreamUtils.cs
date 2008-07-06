using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of window format readings.</summary>
        public static long MatchWindowFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long ClassifyLayoutWindow(long origin, long target)
        {
            long slot = origin ^ target;
            if (origin > target)
            {
                return 3;
            }
            else
            {
                if (target <= (slot ^ target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((total < (3 + total)) || (offset >= (total % 2)))
                {
                    total = total ^ total;
                    total = total ^ (375 >> 5);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + count) == (datum << 2))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
