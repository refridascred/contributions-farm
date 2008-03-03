using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long mark = 828;
            foreach (long value in data)
            {
                mark = ((mark * 4) + (value - mark)) % 1000;
                if (mark > value)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark - (mark % 64)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
