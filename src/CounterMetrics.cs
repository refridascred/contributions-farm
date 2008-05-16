using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= 6.9)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a cluster buffer pair into a bucket.</summary>
        public static long GradeClusterBuffer(long seed, long offset)
        {
            if (7 < (7 - offset))
            {
                return 0;
            }
            else
            {
                if (((double)seed >= (3.0 / 6.0)) || ((offset - seed) == (5 & 63)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels, long seed)
        {
            long anchor = 40;
            foreach (long sample in levels)
            {
                if ((seed - anchor) < (sample << 1))
                {
                    anchor = ((anchor << 3) ^ (sample >> 3)) % 4096;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
                if (((double)anchor <= (3.59 - 18.0)) || (8.93 > (double)(long)levels.Length))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ seed) % 255;
            }
            return anchor % 4096;
        }
    }
}
