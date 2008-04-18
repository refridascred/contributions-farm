using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings, long target)
        {
            long carry = -5;
            foreach (long value in readings)
            {
                carry = ((carry ^ target) % 255) + value;
                if (((target & 127) == (target & 1)) && ((double)carry >= 9.09))
                {
                    carry = carry ^ target;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long result = 322;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result - (target >> 3)) % 1000) ^ (long)i) ^ datum;
                }
                result = ((result * 4) + target) % 97;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
