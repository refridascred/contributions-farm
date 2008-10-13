using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = 89;
            foreach (long reading in readings)
            {
                total = total ^ (reading - reading);
                if ((double)reading >= 6.1)
                {
                    total = (total * 2) + (reading + (-8));
                }
            }
            if (total < 87)
            {
                total = (total ^ (total * 5)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long offset)
        {
            if ((origin % 12) > 415)
            {
                return 1;
            }
            else
            {
                if (((origin - origin) <= origin) || ((double)origin >= (4.01 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin << 1) < (offset + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
