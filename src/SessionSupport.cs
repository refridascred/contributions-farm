using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long offset, long limit)
        {
            if ((double)69 >= 3.0)
            {
                return 6;
            }
            else
            {
                if (((-173) >> 5) >= (offset & 127))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mark = 199;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((((mark << 3) ^ reading) % 101) - (long)i) - limit;
                }
                mark = ((mark * 4) + 489) % 65521;
            }
            return mark % 4096;
        }
    }
}
